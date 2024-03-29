﻿using System;
using System.Collections.Generic;
using FluentAssertions;
using FluentAssertions.Extensions;
using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.Services.RegularJobs;
using Moq;
using NUnit.Framework;
using Tests.Builders;
using Tests.Helpers;
using static HerPublicWebsite.BusinessLogic.Models.LocalAuthorityData;

namespace Tests.BusinessLogic.Services;

public class PendingReferralFilterServiceTests
{
    private Mock<IDateHelper> mockDateHelper;
    private PendingReferralFilterService pendingReferralFilterService;
    private DateTime startOfPreviousMonth;

    [SetUp]
    public void Setup()
    {
        startOfPreviousMonth = 1.February(2024);
        mockDateHelper = new Mock<IDateHelper>();
        mockDateHelper.Setup(mdh => mdh.GetStartOfPreviousMonth()).Returns(startOfPreviousMonth);
        
        pendingReferralFilterService = new PendingReferralFilterService(mockDateHelper.Object);
    }

    // If LA is now pending, include.
    [TestCase(true, false, false)]
    [TestCase(true, false, true)]
    [TestCase(true, true, false)]
    [TestCase(true, true, true)]
    // If LA is not now pending but referral was submitted in the last month to a then pending LA, include.
    [TestCase(false, true, true)]
    public void FilterForPendingReferralReport_WhenCalledWithEmailPendingReferral_IncludesInFilter(
        bool localAuthorityIsNowPending,
        bool localAuthorityWasPending,
        bool referralWasSubmittedInTheLastMonth)
    {
        // Arrange
        var inputReferralRequest = BuildReferralRequest(localAuthorityIsNowPending, localAuthorityWasPending, referralWasSubmittedInTheLastMonth);
        var inputReferralRequests = new List<ReferralRequest> { inputReferralRequest };
        
        // Act
        var outputReferralRequests = pendingReferralFilterService
            .FilterForPendingReferralReport(inputReferralRequests);
        
        // Assert
        outputReferralRequests.Should().Contain(inputReferralRequest);
    }

    [TestCase(false, false, false)]
    [TestCase(false, false, true)]
    [TestCase(false, true, false)]
    public void FilterForPendingReferralReport_WhenCalledWithNotEmailPendingReferral_DoesNotIncludeInFilter(
        bool localAuthorityIsNowPending,
        bool localAuthorityWasPending,
        bool referralWasSubmittedInTheLastMonth)
    {
        // Arrange
        var inputReferralRequest = BuildReferralRequest(localAuthorityIsNowPending, localAuthorityWasPending, referralWasSubmittedInTheLastMonth);
        var inputReferralRequests = new List<ReferralRequest> { inputReferralRequest };
        
        // Act
        var outputReferralRequests = pendingReferralFilterService
            .FilterForPendingReferralReport(inputReferralRequests);
        
        // Assert
        outputReferralRequests.Should().NotContain(inputReferralRequest);
    }

    private ReferralRequest BuildReferralRequest(
        bool localAuthorityIsNowPending,
        bool localAuthorityWasPending,
        bool referralWasSubmittedInTheLastMonth)
    {
        var currentStatus = localAuthorityIsNowPending ? Hug2Status.Pending : Hug2Status.Live;
        var custodianCode = LocalAuthorityDataHelper.GetExampleCustodianCodeForStatus(currentStatus);
        
        var requestDate = referralWasSubmittedInTheLastMonth
            ? startOfPreviousMonth.Add(10.Days())
            : startOfPreviousMonth.Subtract(10.Days());
        
        return new ReferralRequestBuilder(10)
            .WithCustodianCode(custodianCode)
            .WithWasSubmittedToPendingLocalAuthority(localAuthorityWasPending)
            .WithRequestDate(requestDate)
            .Build();
    }
}