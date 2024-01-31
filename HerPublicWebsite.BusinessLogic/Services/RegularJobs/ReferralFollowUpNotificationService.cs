using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;
using HerPublicWebsite.BusinessLogic.Services.ReferralFollowUps;

namespace HerPublicWebsite.BusinessLogic.Services.RegularJobs;

public interface IReferralFollowUpNotificationService
{
    public Task SendReferralFollowUpNotifications();
}

public class ReferralFollowUpNotificationService : IReferralFollowUpNotificationService
{
    private readonly IDataAccessProvider dataProvider;
    private readonly CsvFileCreator.CsvFileCreator csvFileCreator;
    private readonly IWorkingDayHelperService workingDayHelperService;
    private readonly IReferralFollowUpService referralFollowUpManager;
    private readonly IEmailSender emailSender;

    public ReferralFollowUpNotificationService(
        IEmailSender emailSender,
        IDataAccessProvider dataProvider,
        CsvFileCreator.CsvFileCreator csvFileCreator, 
        IWorkingDayHelperService workingDayHelperService,
        IReferralFollowUpService referralFollowUpManager
        )
    {
        this.emailSender = emailSender;
        this.dataProvider = dataProvider;
        this.csvFileCreator = csvFileCreator;
        this.workingDayHelperService = workingDayHelperService;
        this.referralFollowUpManager = referralFollowUpManager;
    }

    public async Task SendReferralFollowUpNotifications()
    {
        var endDate = await workingDayHelperService.AddWorkingDaysToDateTime(DateTime.Today, -10);
        var newReferrals = await dataProvider.GetReferralRequestsWithNoFollowUpBeforeDate(endDate);
        foreach (var newReferral in newReferrals) {
            var referralRequestFollowUp = await referralFollowUpManager.CreateReferralRequestFollowUp(newReferral);
            emailSender.SendFollowUpEmail(newReferral, referralRequestFollowUp.Token);
        }
    }
}

