using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;
using HerPublicWebsite.BusinessLogic.Services.ReferralFollowUps;
using Microsoft.Extensions.Options;

namespace HerPublicWebsite.BusinessLogic.Services.RegularJobs;

public interface IReferralFollowUpNotificationService
{
    public Task SendReferralFollowUpNotifications();
}

public class ReferralFollowUpNotificationService : IReferralFollowUpNotificationService
{
    private readonly GlobalConfiguration config;
    private readonly IDataAccessProvider dataProvider;
    private readonly CsvFileCreator.CsvFileCreator csvFileCreator;
    private readonly IWorkingDayHelperService workingDayHelperService;
    private readonly IReferralFollowUpService referralFollowUpManager;
    private readonly IEmailSender emailSender;

    public ReferralFollowUpNotificationService(
        IOptions<GlobalConfiguration> options,
        IEmailSender emailSender,
        IDataAccessProvider dataProvider,
        CsvFileCreator.CsvFileCreator csvFileCreator, 
        IWorkingDayHelperService workingDayHelperService,
        IReferralFollowUpService referralFollowUpManager
        )
    {
        config = options.Value;
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
        var uriBuilder = new UriBuilder(config.AppBaseUrl);
        uriBuilder.Path = "referral-follow-up";
        foreach (var newReferral in newReferrals) {
            var referralRequestFollowUp = await referralFollowUpManager.CreateReferralRequestFollowUp(newReferral);
            uriBuilder.Query = "token=" + referralRequestFollowUp.Token;
            emailSender.SendFollowUpEmail(newReferral, uriBuilder.ToString());
            await dataProvider.UpdateReferralRequestByIdWithFollowUpSentAsync(newReferral.Id);
        }
    }
}

