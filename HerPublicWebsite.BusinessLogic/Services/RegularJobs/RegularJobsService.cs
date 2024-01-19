using HerPublicWebsite.BusinessLogic.ExternalServices.Common;
using HerPublicWebsite.BusinessLogic.ExternalServices.S3FileWriter;
using HerPublicWebsite.BusinessLogic.Services.ReferralFollowUps;
using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;

namespace HerPublicWebsite.BusinessLogic.Services.RegularJobs;

public interface IRegularJobsService
{
    public Task RunNightlyTasksAsync();
    public Task RunWeeklyTasksAsync();

    public Task WriteUnsubmittedReferralRequestToCsv();
    public Task GetReferralsPassedTenWorkingDayThresholdWithNoFollowUpAndTriggerEmail();
    public Task<DateTime> AddWorkingDaysToDateTime(DateTime initialDateTime, int workingDaysToAdd);
}

public class RegularJobsService : IRegularJobsService
{
    private readonly IDataAccessProvider dataProvider;
    private readonly IS3FileWriter s3FileWriter;
    private readonly CsvFileCreator.CsvFileCreator csvFileCreator;
    private readonly IReferralFollowUpService referralFollowUpManager;
    private readonly IEmailSender emailSender;

    public RegularJobsService(
        IDataAccessProvider dataProvider,
        IS3FileWriter s3FileWriter,
        CsvFileCreator.CsvFileCreator csvFileCreator,
        IReferralFollowUpService referralFollowUpManager, 
        IEmailSender emailSender
        )
    {
        this.dataProvider = dataProvider;
        this.s3FileWriter = s3FileWriter;
        this.csvFileCreator = csvFileCreator;
        this.referralFollowUpManager = referralFollowUpManager;
        this.emailSender = emailSender;
    }

    public async Task RunNightlyTasksAsync()
    {
        await WriteUnsubmittedReferralRequestToCsv();
        await GetReferralsPassedTenWorkingDayThresholdWithNoFollowUpAndTriggerEmail();
    }

    public async Task RunWeeklyTasksAsync()
    {
        await SendPolicyTeamUpdate();
    }
    private async Task SendPolicyTeamUpdate(){
        var table1 = await WriteTable1();
        emailSender.SendComplianceEmail(table1);

    }
    
    private async Task<MemoryStream> WriteTable1 (){
        DateTime endDate = await AddWorkingDaysToDateTime(DateTime.Now, -10); 
        DateTime startDate = endDate.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
        var newReferrals = await dataProvider.GetReferralRequestsBetweenDates(startDate, endDate);
        return csvFileCreator.CreateReferralRequestOverviewFileData(newReferrals);
    }

    public async Task WriteUnsubmittedReferralRequestToCsv() 
    {
        var newReferrals = await dataProvider.GetUnsubmittedReferralRequestsAsync();

        foreach (var referralsByCustodianMonthAndYear in newReferrals.GroupBy(nr => new { nr.CustodianCode, nr.RequestDate.Month, nr.RequestDate.Year}))
        {
            var grouping = referralsByCustodianMonthAndYear.Key;
            var referralsForFile = await dataProvider.GetReferralRequestsByCustodianAndRequestDateAsync(grouping.CustodianCode, grouping.Month, grouping.Year);

            using (var fileData = csvFileCreator.CreateReferralRequestFileData(referralsForFile))
            {
                await s3FileWriter.WriteFileAsync(grouping.CustodianCode, grouping.Month, grouping.Year, fileData);
            }

            foreach (var referralRequest in referralsForFile)
            {
                referralRequest.ReferralWrittenToCsv = true;
            }

            await dataProvider.PersistAllChangesAsync();
        }
    }

    public async Task GetReferralsPassedTenWorkingDayThresholdWithNoFollowUpAndTriggerEmail()
    {
        var startDate = await AddWorkingDaysToDateTime(DateTime.Now, -10);
        var newReferrals = await dataProvider.GetReferralRequestsWithNoFollowUpAfterDate(startDate);
        foreach (ReferralRequest newReferral in newReferrals) {
            await referralFollowUpManager.GenerateAndSendFollowUpEmail(newReferral);
        }
    }

    public async Task<DateTime> AddWorkingDaysToDateTime(DateTime initialDateTime, int workingDaysToAdd)
    {
        int direction = workingDaysToAdd < 0 ? -1 : 1;
        List<DateTime> holidays = await getHolidays();
        DateTime newDateTime = initialDateTime;
        while (workingDaysToAdd != 0)
            {
            newDateTime = newDateTime.AddDays(direction);
            if (newDateTime.DayOfWeek != DayOfWeek.Saturday && 
                newDateTime.DayOfWeek != DayOfWeek.Sunday && 
                !holidays.Contains(newDateTime))
            {
                workingDaysToAdd -= direction;
            }
        }
        return newDateTime;
    }

    private async Task<List<DateTime>> getHolidays() {
            var parameters = new RequestParameters
            {
                BaseAddress = "https://www.gov.uk/bank-holidays.json",
            };
            var holidayDataJson = await HttpRequestHelper.SendGetRequestAsync<Dictionary<string, Holidays>>(parameters);
            var englandAndWalesHolidays = holidayDataJson["england-and-wales"];
            return englandAndWalesHolidays.events.Select(x => x.date).ToList();
        }

    private class Holidays {
            public List<Event> events { get; set;}
        }
    private class Event {
            public DateTime date { get; set; }

        }
}

