﻿using HerPublicWebsite.BusinessLogic;
using Microsoft.EntityFrameworkCore;
using HerPublicWebsite.BusinessLogic.Models;

namespace HerPublicWebsite.Data;

public class DataAccessProvider : IDataAccessProvider
{
    private readonly HerDbContext context;

    public DataAccessProvider(HerDbContext context)
    {
        this.context = context;
    }

    public async Task<ReferralRequest> PersistNewReferralRequestAsync(ReferralRequest referralRequest)
    {
        context.ReferralRequests.Add(referralRequest);
        await context.SaveChangesAsync();
        referralRequest.UpdateReferralCode();
        await context.SaveChangesAsync();
        return referralRequest;
    }

    public async Task PersistNotificationConsentAsync(string referralCode, NotificationDetails details)
    {
        if (details.FutureSchemeNotificationConsent)
        {
            if (referralCode is not null)
            {
                var referralRequest =
                    context.ReferralRequests
                    .Single(rr => rr.ReferralCode == referralCode);

                details.ReferralRequest = referralRequest;
            }

            context.NotificationDetails.Add(details);
            await context.SaveChangesAsync();
        }
    }

    public async Task<AnonymisedReport> PersistAnonymisedReportAsync(AnonymisedReport report)
    {
        context.AnonymisedReports.Add(report);
        await context.SaveChangesAsync();

        return report;
    }

    public async Task<PerReferralReport> PersistPerReferralReportAsync(PerReferralReport report)
    {
        context.PerReferralReports.Add(report);
        await context.SaveChangesAsync();

        return report;
    }

    public async Task<IList<ReferralRequest>> GetUnsubmittedReferralRequestsAsync()
    {
        return await context.ReferralRequests
            .Where(rr => !rr.ReferralWrittenToCsv)
            .ToListAsync();
    }

    public async Task<IList<ReferralRequest>> GetReferralRequestsWithNoFollowUpBeforeDate(DateTime cutoffDate)
    {
        return await context.ReferralRequests
            .Where(rr => rr.RequestDate <= cutoffDate && !rr.FollowUpEmailSent)
            .ToListAsync();
    }

    public async Task<IList<ReferralRequest>> GetReferralRequestsByCustodianAndRequestDateAsync(string custodianCode, int month, int year)
    {
        return await context.ReferralRequests
            .Where(rr => rr.CustodianCode == custodianCode && rr.RequestDate.Month == month && rr.RequestDate.Year == year)
            .ToListAsync();
    }

    public async Task<ReferralRequestFollowUp> PersistReferralFollowUpToken(ReferralRequestFollowUp referralRequestFollowUp)
    {
        context.ReferralRequestFollowUps
            .Add(referralRequestFollowUp);
        await context.SaveChangesAsync();
        return referralRequestFollowUp;
    }

    public ReferralRequestFollowUp GetReferralFollowUpByToken(string token)
    {
        return context.ReferralRequestFollowUps.Include(rrfu => rrfu.ReferralRequest).Single(rrfu => rrfu.Token == token);
    }
    
    public async Task<ReferralRequestFollowUp> UpdateReferralFollowUpByTokenWithWasFollowedUp(string token, bool wasFollowedUp)
    {   
        ReferralRequestFollowUp referralRequestFollowUp = context.ReferralRequestFollowUps.Single(rrfu => rrfu.Token == token);
        referralRequestFollowUp.WasFollowedUp = wasFollowedUp;
        referralRequestFollowUp.DateOfFollowUpResponse = DateTime.Now;
        await context.SaveChangesAsync();
        return referralRequestFollowUp;
    }

    public async Task PersistAllChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}
