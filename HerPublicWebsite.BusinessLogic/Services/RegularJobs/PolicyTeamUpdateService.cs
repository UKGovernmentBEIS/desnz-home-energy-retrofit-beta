using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;
using HerPublicWebsite.BusinessLogic.Services.WorkingDayHelper;

namespace HerPublicWebsite.BusinessLogic.Services.PolicyTeamUpdate;

public interface IPolicyTeamUpdate
{
    public Task SendPolicyTeamUpdate();
}

public class PolicyTeamUpdateService : IPolicyTeamUpdate
{
    private readonly IDataAccessProvider dataProvider;
    private readonly CsvFileCreator.CsvFileCreator csvFileCreator;
    private readonly IWorkingDayHelperService workingDayHelperService;
    private readonly IEmailSender emailSender;
    
    public PolicyTeamUpdateService(
        IDataAccessProvider dataProvider,
        CsvFileCreator.CsvFileCreator csvFileCreator, 
        IWorkingDayHelperService workingDayHelperService,
        IEmailSender emailSender
    )
    {
        this.dataProvider = dataProvider;
        this.csvFileCreator = csvFileCreator;
        this.workingDayHelperService = workingDayHelperService;
        this.emailSender = emailSender;
    }

    public async Task SendPolicyTeamUpdate(){
        var recentReferralRequestOverviewTable = await BuildRecentReferralRequestOverviewTable();
        var recentReferralRequestFollowUpTable = await BuildRecentReferralRequestFollowUpTable();
        var historicReferralRequestFollowUpTable = await BuildHistoricReferralRequestFollowUpTable();
        emailSender.SendComplianceEmail(
            recentReferralRequestOverviewTable,
            recentReferralRequestFollowUpTable,
            historicReferralRequestFollowUpTable
        );

    }

    private async Task<MemoryStream> BuildRecentReferralRequestOverviewTable (){
        DateTime endDate = await workingDayHelperService.AddWorkingDaysToDateTime(DateTime.Now, -10); 
        DateTime startDate = endDate.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
        var newReferrals = await dataProvider.GetReferralRequestsBetweenDates(startDate, endDate);
        return csvFileCreator.CreateReferralRequestOverviewFileData(newReferrals);
    }

    private async Task<MemoryStream> BuildRecentReferralRequestFollowUpTable (){
        DateTime endDate = await workingDayHelperService.AddWorkingDaysToDateTime(DateTime.Now, -10); 
        DateTime startDate = await workingDayHelperService.AddWorkingDaysToDateTime(DateTime.Now.AddDays(-7), -10); 
        var newReferrals = await dataProvider.GetReferralRequestsBetweenDates(startDate, endDate);
        return csvFileCreator.CreateReferralRequestFollowUpData(newReferrals);
    }

    private async Task<MemoryStream> BuildHistoricReferralRequestFollowUpTable (){
        var newReferrals = await dataProvider.GetAllReferralRequests();
        return csvFileCreator.CreateReferralRequestFollowUpData(newReferrals);
    }
}
