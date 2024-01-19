using HerPublicWebsite.BusinessLogic.Models;

namespace HerPublicWebsite.BusinessLogic;

public interface IDataAccessProvider
{
    Task<ReferralRequest> PersistNewReferralRequestAsync(ReferralRequest referralRequest);
    Task PersistNotificationConsentAsync(string referralId, NotificationDetails notificationDetails);
    Task<IList<ReferralRequest>> GetUnsubmittedReferralRequestsAsync();
    Task<IList<ReferralRequest>> GetReferralRequestsBetweenDates(DateTime startDate, DateTime endDate);
    Task<IList<ReferralRequest>> GetReferralRequestsWithNoFollowUpAfterDate(DateTime date);
    Task<IList<ReferralRequest>> GetReferralRequestsByCustodianAndRequestDateAsync(string custodianCode, int month, int year);
    Task<AnonymisedReport> PersistAnonymisedReportAsync(AnonymisedReport report);
    Task<PerReferralReport> PersistPerReferralReportAsync(PerReferralReport report);
    Task PersistAllChangesAsync();
    Task<ReferralRequestFollowUp> AddReferralFollowUpToken(ReferralRequestFollowUp referralRequestFollowUp);
    ReferralRequestFollowUp GetReferralFollowUpByToken(string token);
    Task<ReferralRequestFollowUp> UpdateReferralFollowUpByTokenWithWasFollowedUp(string token, bool wasFollowedUp);
}
