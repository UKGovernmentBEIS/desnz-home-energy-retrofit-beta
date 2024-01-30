using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.Services.ReferralFollowUps;

namespace HerPublicWebsite.BusinessLogic.Services.RegularJobs;

public interface IReferralFollowUpJobService
{
    public Task GetReferralsPassedTenWorkingDayThresholdWithNoFollowUpAndTriggerEmail();
}

public class ReferralFollowUpJobService : IReferralFollowUpJobService
{
    private readonly IDataAccessProvider dataProvider;
    private readonly CsvFileCreator.CsvFileCreator csvFileCreator;
    private readonly IWorkingDayHelperService workingDayHelperService;
    private readonly IReferralFollowUpService referralFollowUpManager;
    
    public ReferralFollowUpJobService(
        IDataAccessProvider dataProvider,
        CsvFileCreator.CsvFileCreator csvFileCreator, 
        IWorkingDayHelperService workingDayHelperService,
        IReferralFollowUpService referralFollowUpManager
        )
    {
        this.dataProvider = dataProvider;
        this.csvFileCreator = csvFileCreator;
        this.workingDayHelperService = workingDayHelperService;
        this.referralFollowUpManager = referralFollowUpManager;
    }

    public async Task GetReferralsPassedTenWorkingDayThresholdWithNoFollowUpAndTriggerEmail()
    {
        var endDate = await workingDayHelperService.AddWorkingDaysToDateTime(DateTime.Today, -10);
        var newReferrals = await dataProvider.GetReferralRequestsWithNoFollowUpBeforeDate(endDate);
        foreach (ReferralRequest newReferral in newReferrals) {
            await referralFollowUpManager.GenerateAndSendFollowUpEmail(newReferral);
        }
    }
}

