﻿using System;
using System.Threading.Tasks;
using FluentAssertions;
using HerPublicWebsite.BusinessLogic;
using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;
using HerPublicWebsite.BusinessLogic.ExternalServices.EpbEpc;
using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.Models.Enums;
using HerPublicWebsite.BusinessLogic.Services.EligiblePostcode;
using HerPublicWebsite.BusinessLogic.Services.QuestionFlow;
using Moq;
using NUnit.Framework;

namespace Tests.BusinessLogic;

[TestFixture]
public class QuestionnaireUpdaterTests
{
    private QuestionnaireUpdater underTest;
    private Mock<IEpcApi> mockEpcApi;
    private Mock<IEligiblePostcodeService> mockPostCodeService;
    private Mock<IDataAccessProvider> mockDataAccessProvider;
    private Mock<IEmailSender> mockEmailSender;
    private Mock<IQuestionFlowService> mockQuestionFlowService;
    
    
    [SetUp]
    public void Setup()
    {
        mockEpcApi = new Mock<IEpcApi>();
        mockPostCodeService = new Mock<IEligiblePostcodeService>();
        mockDataAccessProvider = new Mock<IDataAccessProvider>();
        mockEmailSender = new Mock<IEmailSender>();
        mockQuestionFlowService = new Mock<IQuestionFlowService>();
        underTest = new QuestionnaireUpdater
        (
            mockEpcApi.Object,
            mockPostCodeService.Object,
            mockDataAccessProvider.Object,
            mockEmailSender.Object,
            mockQuestionFlowService.Object
        );
    }
    
    [Test]
    public async Task UpdateAddressAsync_CalledWithUprn_GetsEpcDetails()
    {
        // Arrange
        var questionnaire = new Questionnaire();
        var address = new Address()
        {
            AddressLine1 = "line1",
            County = "county",
            Postcode = "ab1 2cd",
            Uprn = "123456789012"
        };
        var epcDetails = new EpcDetails()
        {
            AddressLine1 = "epc line 1",
        };
        mockEpcApi.Setup(e => e.EpcFromUprnAsync("123456789012")).ReturnsAsync(epcDetails);
        
        // Act
        var result = await underTest.UpdateAddressAsync(questionnaire, address, null);
        
        // Assert
        mockEpcApi.Verify(e => e.EpcFromUprnAsync("123456789012"));
        result.EpcDetails.Should().Be(epcDetails);
        result.EpcDetailsAreCorrect.Should().BeNull();
    }
    
    [Test]
    public async Task UpdateAddressAsync_CalledWithoutUprn_ResetsEpcDetails()
    {
        // Arrange
        var questionnaire = new Questionnaire
        {
            EpcDetails = new EpcDetails()
        };
        var address = new Address()
        {
            AddressLine1 = "line1",
            County = "county",
            Postcode = "ab1 2cd"
        };

        // Act
        var result = await underTest.UpdateAddressAsync(questionnaire, address, null);
        
        // Assert
        mockEpcApi.VerifyNoOtherCalls();
        result.EpcDetails.Should().BeNull();
        result.EpcDetailsAreCorrect.Should().BeNull();
    }
    
    [TestCase(true)]
    [TestCase(false)]
    public async Task UpdateAddressAsync_WhenCalled_SetsLsoaStatusToMatchEligibility(bool isEligible)
    {
        // Arrange
        var postcode = "ab1 2cd";
        var questionnaire = new Questionnaire();
        var address = new Address()
        {
            AddressLine1 = "line1",
            County = "county",
            Postcode = postcode
        };
        mockPostCodeService.Setup(pcs => pcs.IsEligiblePostcode(postcode)).Returns(isEligible);

        // Act
        var result = await underTest.UpdateAddressAsync(questionnaire, address, null);
        
        // Assert
        result.IsLsoaProperty.Should().Be(isEligible);
    }

    [Test]
    public void UpdateLocalAuthority_WhenCalled_ResetsLocalAuthorityConfirmed()
    {
        // Arrange
        var questionnaire = new Questionnaire()
        {
            CustodianCode = "old code",
            LocalAuthorityConfirmed = true
        };
        
        // Act
        var result = underTest.UpdateLocalAuthority(questionnaire, "new code", null);
        
        // Assert
        result.LocalAuthorityConfirmed.Should().BeNull();
        result.CustodianCode.Should().Be("new code");
    }

    [Test]
    public async Task GenerateReferralAsync_WhenCalled_PersistReferral()
    {
        // Arrange
        var questionnaire = new Questionnaire
        {
            IsLsoaProperty = false,
            IncomeBand = IncomeBand.UnderOrEqualTo31000,
            HasGasBoiler = HasGasBoiler.No
        };
        mockDataAccessProvider.Setup(dap =>
            dap.PersistNewReferralRequestAsync(It.IsAny<ReferralRequest>())).ReturnsAsync(new ReferralRequest());
        
        // Act
        await underTest.GenerateReferralAsync(questionnaire, "name", "email", "telephone");
        
        // Assert
        mockDataAccessProvider.Verify(dap => dap.PersistNewReferralRequestAsync(It.IsAny<ReferralRequest>()));
    }
    
    [Test]
    public async Task GenerateReferralAsync_WhenCalled_UpdatesQuestionnaireContactDetails()
    {
        // Arrange
        var questionnaire = new Questionnaire
        {
            IsLsoaProperty = false,
            IncomeBand = IncomeBand.UnderOrEqualTo31000,
            HasGasBoiler = HasGasBoiler.No
        };
        mockDataAccessProvider.Setup(dap =>
            dap.PersistNewReferralRequestAsync(It.IsAny<ReferralRequest>())).ReturnsAsync(new ReferralRequest());
        
        // Act
        var result = await underTest.GenerateReferralAsync(questionnaire, "name", "email", "telephone");
        
        // Assert
        result.LaContactName.Should().Be("name");
        result.LaContactEmailAddress.Should().Be("email");
        result.LaContactTelephone.Should().Be("telephone");
    }
    
    [Test]
    public async Task GenerateReferralAsync_WhenCalled_UpdatesQuestionnaireReferralData()
    {
        // Arrange
        var questionnaire = new Questionnaire
        {
            IsLsoaProperty = false,
            IncomeBand = IncomeBand.UnderOrEqualTo31000,
            HasGasBoiler = HasGasBoiler.No
        };
        var creationDate = new DateTime(2023, 01, 01, 13, 0, 0);
        var referral = new ReferralRequest
        {
            ReferralCode = "code",
            RequestDate = creationDate
        };
        mockDataAccessProvider.Setup(dap =>
            dap.PersistNewReferralRequestAsync(It.IsAny<ReferralRequest>())).ReturnsAsync(referral);
        
        // Act
        var result = await underTest.GenerateReferralAsync(questionnaire, "name", "email", "telephone");
        
        // Assert
        result.Hug2ReferralId.Should().Be("code");
        result.ReferralCreated.Should().Be(creationDate);
    }
    
    [Test]
    public async Task GenerateReferralAsync_WhenCalledWithEmail_SendOneEmailWithReferralCode()
    {
        // Arrange
        const string testCustodianCode = "1234";
        const string testReferralCode = "referral code";
        const string testName = "Example Person";
        const string testEmailAddress = "test@example.com";
        var questionnaire = new Questionnaire
        {
            CustodianCode = testCustodianCode,
            IsLsoaProperty = false,
            IncomeBand = IncomeBand.UnderOrEqualTo31000,
            HasGasBoiler = HasGasBoiler.No
        };
        var creationDate = new DateTime(2023, 01, 01, 13, 0, 0);
        var referral = new ReferralRequest
        {
            CustodianCode = testCustodianCode,
            ReferralCode = testReferralCode,
            RequestDate = creationDate
        };
        mockDataAccessProvider.Setup(dap =>
            dap.PersistNewReferralRequestAsync
            (
                It.Is<ReferralRequest>(rr => rr.CustodianCode == testCustodianCode)
            )).ReturnsAsync(referral);
        mockEmailSender.Setup(es =>
            es.SendReferenceCodeEmail
            (
                testEmailAddress,
                testName,
                testReferralCode,
                testCustodianCode
            )
        );

        // Act
        var result = await underTest.GenerateReferralAsync
        (
            questionnaire,
            testName,
            testEmailAddress,
            ""
        );
        
        // Assert
        mockEmailSender.Verify(es => es.SendReferenceCodeEmail
        (
            testEmailAddress,
            testName,
            testReferralCode,
            testCustodianCode
        ), Times.Once);
    }
    
    [Test]
    public async Task GenerateReferralAsync_WhenCalledWithoutEmail_DoesNotSendEmail()
    {
        // Arrange
        const string testReferralCode = "referral code";
        const string testName = "Example Person";
        var questionnaire = new Questionnaire
        {
            IsLsoaProperty = false,
            IncomeBand = IncomeBand.UnderOrEqualTo31000,
            HasGasBoiler = HasGasBoiler.No
        };
        var creationDate = new DateTime(2023, 01, 01, 13, 0, 0);
        var referral = new ReferralRequest
        {
            ReferralCode = testReferralCode,
            RequestDate = creationDate
        };
        mockDataAccessProvider.Setup(dap =>
            dap.PersistNewReferralRequestAsync(It.IsAny<ReferralRequest>())).ReturnsAsync(referral);
        mockEmailSender.Setup(es =>
            es.SendReferenceCodeEmail
            (
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
            )
        );

        // Act
        var result = await underTest.GenerateReferralAsync
        (
            questionnaire,
            testName,
            "",
            ""
        );
        
        // Assert
        mockEmailSender.Verify(es => es.SendReferenceCodeEmail
        (
            It.IsAny<string>(),
            It.IsAny<string>(),
            It.IsAny<string>(),
            It.IsAny<string>()
        ), Times.Never);
    }
    
    [Test]
    public async Task RecordNotificationConsentAsync_WhenCalledWithLaContactEmail_PersistsConsent()
    {
        // Arrange
        var questionnaire = new Questionnaire
        {
            LaContactEmailAddress = "test@example.com",
            Hug2ReferralId = "referral code"
        };
        
        // Act
        await underTest.RecordNotificationConsentAsync(questionnaire, true);
        
        // Assert
        mockDataAccessProvider.Verify(dap => dap.PersistNotificationConsentAsync("referral code",It.IsAny<NotificationDetails>()));
    }
    
    [Test]
    public async Task RecordNotificationConsentAsync_WhenCalledWithLaContactEmailAndConsent_UsesLaContactEmail()
    {
        // Arrange
        var questionnaire = new Questionnaire
        {
            LaContactEmailAddress = "test@example.com",
            Hug2ReferralId = "referral code"
        };

        // Act
        var result = await underTest.RecordNotificationConsentAsync(questionnaire, true);
        
        // Assert
        result.NotificationConsent.Should().BeTrue();
        result.NotificationEmailAddress.Should().Be("test@example.com");
    }
    
    [Test]
    public async Task RecordNotificationConsentAsync_WhenCalledWithLaContactEmailAndNoConsent_UsesNullEmail()
    {
        // Arrange
        var questionnaire = new Questionnaire
        {
            LaContactEmailAddress = "test@example.com",
            Hug2ReferralId = "referral code"
        };

        // Act
        var result = await underTest.RecordNotificationConsentAsync(questionnaire, false);
        
        // Assert
        result.NotificationConsent.Should().BeFalse();
        result.NotificationEmailAddress.Should().BeNull();
    }

    [TestCase(true, "test@example.com")]
    [TestCase(false, "")]
    public async Task RecordConfirmationAndNotificationConsentAsync_WhenConfirmationConsentGrantedAndEmailGiven_SendsOneEmailWithReferralCode
    (
        bool notificationConsentGranted,
        string notificationEmailAddress
    ) {
        // Arrange
        const string testCustodianCode = "1234";
        const string testReferralCode = "referral code";
        const string testName = "Example Person";
        const string testEmailAddress = "test@example.com";
        var questionnaire = new Questionnaire
        {
            LaContactName = testName,
            LaContactEmailAddress = testEmailAddress,
            Hug2ReferralId = testReferralCode,
            CustodianCode = testCustodianCode,
        };
        mockEmailSender.Setup(es =>
            es.SendReferenceCodeEmail
            (
                testEmailAddress,
                testName,
                testReferralCode,
                testCustodianCode
            )
        );
        
        // Act
        var result = await underTest.RecordConfirmationAndNotificationConsentAsync
        (
            questionnaire,
            notificationConsentGranted,
            notificationEmailAddress,
            true,
            testEmailAddress
        );
        
        // Assert
        mockEmailSender.Verify(es => es.SendReferenceCodeEmail
        (
            testEmailAddress,
            testName,
            testReferralCode,
            testCustodianCode
        ), Times.Once);
    }
    
    [TestCase(true, "test@example.com")]
    [TestCase(false, "")]
    public async Task RecordConfirmationAndNotificationConsentAsync_WhenConfirmationConsentNotGrantedAndEmailNotGiven_DoesNotSendEmail
    (
        bool notificationConsentGranted,
        string notificationEmailAddress
    ) {
        // Arrange
        const string testCustodianCode = "1234";
        const string testReferralCode = "referral code";
        const string testName = "Example Person";
        var questionnaire = new Questionnaire
        {
            LaContactName = testName,
            Hug2ReferralId = testReferralCode,
            CustodianCode = testCustodianCode,
        };
        mockEmailSender.Setup(es =>
            es.SendReferenceCodeEmail
            (
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
            )
        );
        
        // Act
        var result = await underTest.RecordConfirmationAndNotificationConsentAsync
        (
            questionnaire,
            notificationConsentGranted,
            notificationEmailAddress,
            false,
            ""
        );
        
        // Assert
        mockEmailSender.Verify(es => es.SendReferenceCodeEmail
        (
            It.IsAny<string>(),
            It.IsAny<string>(),
            It.IsAny<string>(),
            It.IsAny<string>()
        ), Times.Never);
    }
}
