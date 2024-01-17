using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using HerPublicWebsite.BusinessLogic;
using HerPublicWebsite.BusinessLogic.Models;
using NUnit.Framework;
using Moq;
using Tests.Builders;
using HerPublicWebsite.BusinessLogic.Services.ReferralFollowUps;
using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;

namespace Tests.BusinessLogic.Services;

[TestFixture]
public class ReferralRequestFollowUpServiceTests
{
    private IReferralFollowUpService referralFollowUpService;
    private Mock<IEmailSender> mockEmailSender;
    private Mock<IDataAccessProvider> mockDataAccessProvider;
    private Mock<IGuidService> mockGuidService;

    [SetUp]
    public void Setup()
    {
        mockEmailSender = new Mock<IEmailSender>();
        mockDataAccessProvider = new Mock<IDataAccessProvider>();
        mockGuidService = new Mock<IGuidService>();
        referralFollowUpService = new ReferralFollowUpService(mockEmailSender.Object, mockDataAccessProvider.Object, mockGuidService.Object);
    }

    [Test]
    public async Task GenerateAndSendFollowUpEmail_WhenCalledWithNewReferral_CreatesANewReferralRequestFollowUpInTheDbAndSendsTokenInEmail()
    {
        // Arrange
        string testToken = "testToken";
        var newReferralRequest = new ReferralRequestBuilder(1).WithReferralCreated(false).WithRequestDate(new DateTime(2023, 03, 01)).Build();
        var newReferralRequestFollowUp = new ReferralRequestFollowUp(newReferralRequest, "testToken");

        mockGuidService.Setup(gs => gs.NewGuidString()).Returns("testToken");
        mockDataAccessProvider.Setup(dap => dap.AddReferralFollowUpToken(newReferralRequestFollowUp).Result).Returns(newReferralRequestFollowUp);
     
        // Act
        await referralFollowUpService.GenerateAndSendFollowUpEmail(newReferralRequest);

        // Assert
        mockDataAccessProvider.Verify(dap => dap.AddReferralFollowUpToken(newReferralRequestFollowUp));
        mockEmailSender.Verify(es => es.SendFollowUpEmail(newReferralRequest, It.IsAny<string>()));
    }
    
    [TestCase(true)]
    [TestCase(false)]
    public async Task RecordFollowUpResponseForToken_WhenCalledWithTokenWhereAReferralRequestHasNotBeenFollowedUp_UpdatesReferralRequestFollowUp(bool hasFollowedUp)
    {
        // Arrange
        string testToken = "testToken";
        var newReferralRequest = new ReferralRequestBuilder(1).WithReferralCreated(false).WithRequestDate(new DateTime(2023, 03, 01)).Build();
        var newReferralRequestFollowUp = new ReferralRequestFollowUp(newReferralRequest, testToken);

        mockDataAccessProvider.Setup(dap => dap.GetReferralFollowUpByToken(testToken)).Returns(newReferralRequestFollowUp);
        
        // Act
        await referralFollowUpService.RecordFollowUpResponseForToken(testToken, hasFollowedUp);

        // Assert
        mockDataAccessProvider.Verify(dap => dap.UpdateReferralFollowUpByTokenWithWasFollowedUp(testToken, hasFollowedUp));
    }

    [Test]
    public async Task RecordFollowUpResponseForToken_WhenCalledWithTokenWhereAReferralRequestHasAlreadyBeenFollowedUp_ThrowsInvalidOperationException()
    {
        // Arrange
        string testToken = "testToken";
        var newReferralRequest = new ReferralRequestBuilder(1).WithReferralCreated(false).WithRequestDate(new DateTime(2023, 03, 01)).Build();
        var newReferralRequestFollowUp = new ReferralRequestFollowUp(newReferralRequest, testToken)
        {
            WasFollowedUp = true
        };

        mockDataAccessProvider.Setup(dap => dap.GetReferralFollowUpByToken(testToken)).Returns(newReferralRequestFollowUp);
        
        // Act
        // Assert
        Assert.ThrowsAsync<InvalidOperationException>(() => referralFollowUpService.RecordFollowUpResponseForToken(testToken, true));
     }
}
