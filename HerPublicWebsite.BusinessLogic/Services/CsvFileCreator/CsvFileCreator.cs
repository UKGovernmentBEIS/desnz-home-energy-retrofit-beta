using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.Models.Enums;

namespace HerPublicWebsite.BusinessLogic.Services.CsvFileCreator;

public class CsvFileCreator
{
    public MemoryStream CreateReferralRequestFileData(IEnumerable<ReferralRequest> referralRequests)
    {
        var rows = referralRequests.Select(rr => new CsvRowReferralRequest(rr));

        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            InjectionOptions = InjectionOptions.Strip
        };

        using var writeableMemoryStream = new MemoryStream();
        using var streamWriter = new StreamWriter(writeableMemoryStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfiguration);
        {
            csvWriter.WriteRecords(rows);
            csvWriter.Flush();
            return new MemoryStream(writeableMemoryStream.GetBuffer(), 0, (int)writeableMemoryStream.Length, false);
        }
    }

    public MemoryStream CreateReferralRequestOverviewFileData(IEnumerable<ReferralRequest> referralRequests)
    {
        var rows = referralRequests.Select(rr => new CsvRowReferralCodes(rr));

        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            InjectionOptions = InjectionOptions.Strip
        };

        using var writeableMemoryStream = new MemoryStream();
        using var streamWriter = new StreamWriter(writeableMemoryStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfiguration);
        {
            csvWriter.WriteRecords(rows);
            csvWriter.Flush();
            return new MemoryStream(writeableMemoryStream.GetBuffer(), 0, (int)writeableMemoryStream.Length, false);
        }
    }

    public MemoryStream CreateReferralRequestFollowUpData(IEnumerable<ReferralRequest> referralRequests)
    {
        var consortiumData = referralRequests.GroupBy(rr => LocalAuthorityData.LocalAuthorityDetailsByCustodianCode[rr.CustodianCode].Consortium)
            .Select(group => new CsvRowConsortiumFollowUpInformation(group));

        var rows = referralRequests.GroupBy(rr => rr.CustodianCode)
            .Select(group => new CsvRowLaDownloadInformation(
                group, consortiumData.First(csd => csd.Consortium == (LocalAuthorityData.LocalAuthorityDetailsByCustodianCode[group.Key].Consortium ?? "None")))
            );
        
        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            InjectionOptions = InjectionOptions.Strip
        };

        using var writeableMemoryStream = new MemoryStream();
        using var streamWriter = new StreamWriter(writeableMemoryStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfiguration);
        {
            csvWriter.WriteRecords(rows);
            csvWriter.Flush();
            return new MemoryStream(writeableMemoryStream.GetBuffer(), 0, (int)writeableMemoryStream.Length, false);
        }
    }

    private class CsvRowReferralCodes
    {
        [Index(0)]
        [Name("Consortium")]
        public string Consortium { get; set; }
        
        [Index(1)]
        [Name("Local Authority")]
        public string LocalAuthority { get; set; }
        
        [Index(2)]
        [Name("Referral Code")]
        public string ReferralCode { get; set; }
        public CsvRowReferralCodes(ReferralRequest request){
            Consortium =  LocalAuthorityData.LocalAuthorityDetailsByCustodianCode[request.CustodianCode].Consortium;
            LocalAuthority =  LocalAuthorityData.LocalAuthorityDetailsByCustodianCode[request.CustodianCode].Name;
            ReferralCode = request.ReferralCode;
        }
    }
    
    private class CsvRowConsortiumFollowUpInformation
    {
        [Index(0)]
        [Name("Consortium")]
        public string Consortium { get; set; }

        [Index(1)]
        [Name("Consortium All Referrals Downloaded")]
        public bool AllConsortiumReferralsDownloaded { get; set; }
        
        [Index(2)]
        [Name("Consortium Number of Referrals Not Downloaded")]
        public int NumberUndownloadedConsortiumReferrals { get; set; }

        [Index(3)]
        [Name("Consortium Percentage of Referrals Not Downloaded")]
        public float PercentageUndownloadedConsortiumReferrals { get; set; }


        [Index(4)]
        [Name("Consortium All Referrals Reported Contacted or No Reply")]
        public bool AllConsortiumReferralsContacted { get; set; }
        
        [Index(5)]
        [Name("Consortium Number of Referrals Reported Not Contacted")]
        public int NumberUncontactedConsortiumReferrals { get; set; }

        [Index(6)]
        [Name("Consortium Percentage of Referrals Reported Not Contacted")]
        public float PercentageUncontactedConsortiumReferrals { get; set; }
        public CsvRowConsortiumFollowUpInformation(IGrouping<string,ReferralRequest> requestGrouping){
            Consortium =  LocalAuthorityData.LocalAuthorityDetailsByCustodianCode[requestGrouping.First().CustodianCode].Consortium ?? "None";
            NumberUndownloadedConsortiumReferrals = requestGrouping.Sum(rr => rr.ReferralWrittenToCsv ? 0 : 1);
            AllConsortiumReferralsDownloaded = NumberUndownloadedConsortiumReferrals == 0;
            PercentageUndownloadedConsortiumReferrals = (float)NumberUndownloadedConsortiumReferrals / requestGrouping.Count();
            NumberUncontactedConsortiumReferrals = requestGrouping.Sum(rr => rr.FollowUp == null ? 0 : rr.FollowUp.WasFollowedUp == false ? 1 : 0);
            AllConsortiumReferralsContacted = NumberUncontactedConsortiumReferrals == 0;
            PercentageUncontactedConsortiumReferrals = (float)NumberUncontactedConsortiumReferrals / requestGrouping.Count();
        }
    }

    private class CsvRowLaDownloadInformation
    {
        [Index(0)]
        [Name("Consortium")]
        public string Consortium { get; set; }

        [Index(1)]
        [Name("Consortium All Referrals Downloaded")]
        public bool AllConsortiumReferralsDownloaded { get; set; }
        
        [Index(2)]
        [Name("Consortium Number of Referrals Not Downloaded")]
        public int NumberUndownloadedConsortiumReferrals { get; set; }

        [Index(3)]
        [Name("Consortium Percentage of Referrals Not Downloaded")]
        public float PercentageUndownloadedConsortiumReferrals { get; set; }

        [Index(4)]
        [Name("Consortium All Referrals Contacted")]
        public bool AllConsortiumReferralsContacted { get; set; }
        
        [Index(5)]
        [Name("Consortium Number of Referrals Not Contacted")]
        public int NumberUncontactedConsortiumReferrals { get; set; }

        [Index(6)]
        [Name("Consortium Percentage of Referrals Not Contacted")]
        public float PercentageUncontactedConsortiumReferrals { get; set; }
        
        [Index(7)]
        [Name("LA")]
        public string LocalAuthority { get; set; }
        
        [Index(8)]
        [Name("LA Number of Referrals Not Downloaded")]
        public int NumberUndownloadedLaReferrals { get; set; }

        [Index(9)]
        [Name("LA Percentage of Referrals Not Downloaded")]
        public float PercentageUndownloadedLaReferrals { get; set; }

        [Index(10)]
        [Name("LA Number of Referrals Not Contacted")]
        public int NumberUncontactedLaReferrals { get; set; }

        [Index(11)]
        [Name("LA Percentage of Referrals Not Contacted")]
        
        public float PercentageUncontactedLaReferrals { get; set; }

        public CsvRowLaDownloadInformation(IGrouping<string,ReferralRequest> requestGrouping, CsvRowConsortiumFollowUpInformation consortiumData){
            Consortium =  LocalAuthorityData.LocalAuthorityDetailsByCustodianCode[requestGrouping.First().CustodianCode].Consortium;
            LocalAuthority =  LocalAuthorityData.LocalAuthorityDetailsByCustodianCode[requestGrouping.First().CustodianCode].Name;
            AllConsortiumReferralsDownloaded = consortiumData.AllConsortiumReferralsDownloaded;
            NumberUndownloadedConsortiumReferrals = consortiumData.NumberUndownloadedConsortiumReferrals;
            PercentageUndownloadedConsortiumReferrals = consortiumData.PercentageUndownloadedConsortiumReferrals;
            AllConsortiumReferralsContacted = consortiumData.AllConsortiumReferralsContacted;
            NumberUncontactedConsortiumReferrals = consortiumData.NumberUncontactedConsortiumReferrals;
            PercentageUncontactedConsortiumReferrals = consortiumData.PercentageUncontactedConsortiumReferrals;
            NumberUndownloadedLaReferrals = requestGrouping.Sum(rr => rr.ReferralWrittenToCsv ? 0 : 1);
            PercentageUndownloadedLaReferrals = (float)NumberUndownloadedLaReferrals/requestGrouping.Count();
            NumberUncontactedLaReferrals = requestGrouping.Sum(rr => rr.FollowUp == null ? 0 : rr.FollowUp.WasFollowedUp == false ? 1 : 0);
            PercentageUncontactedLaReferrals = (float)NumberUncontactedLaReferrals / requestGrouping.Count();
        }
    }

    private class CsvRowReferralRequest
    {
        [Index(0)]
        [Name("Referral date")]
        public string ReferralDate { get; set; }
        
        [Index(1)]
        [Name("Referral code")]
        public string ReferralCode { get; set; }
        
        [Index(2)]
        public string Name { get; set; }
        
        [Index(3)]
        public string Email { get; set; }
        
        [Index(4)]
        public string Telephone { get; set; }

        [Index(5)]
        public string Address1 { get; set; }
        
        [Index(6)]
        public string Address2 { get; set; }
        
        [Index(7)]
        public string Town { get; set; }
        
        [Index(8)]
        public string County { get; set; }
        
        [Index(9)]
        public string Postcode { get; set; }
        
        [Index(10)]
        [Name("UPRN")]
        public string Uprn { get; set; }
        
        [Index(11)]
        [Name("EPC Band")]
        public EpcRating EpcBand { get; set; }

        [Index(12)]
        [Name("EPC confirmed by homeowner")]
        public string EpcConfirmed { get; set; }
        
        [Index(13)]
        [Name("EPC Lodgement Date")]
        public string EpcLodgementDate { get; set; }
        
        [Index(14)]
        [Name("Is off gas grid")]
        [BooleanTrueValues("yes")]
        [BooleanFalseValues("no")]
        public string OffGasGrid { get; set; }
        
        [Index(15)]
        [Name("Household income band")]
        public string HouseholdIncome { get; set; }
        
        [Index(16)]
        [Name("Is eligible postcode")]
        [BooleanTrueValues("yes")]
        [BooleanFalseValues("no")]
        public bool EligiblePostcode { get; set; }
        
        [Index(17)]
        public string Tenure { get; set; }

        public CsvRowReferralRequest(ReferralRequest request)
        {
            ReferralDate = request.RequestDate.ToString("yyyy-MM-dd HH:mm:ss");
            ReferralCode = request.ReferralCode;
            Name = request.FullName;
            Email = request.ContactEmailAddress;
            Telephone = request.ContactTelephone;
            Address1 = request.AddressLine1;
            Address2 = request.AddressLine2;
            Town = request.AddressTown;
            County = request.AddressCounty;
            Postcode = request.AddressPostcode;
            Uprn = request.Uprn;
            EpcBand = request.EpcRating;
            EpcConfirmed = request.EpcConfirmation switch
            {
                // Yes not included here as users can't be referred if they've confirmed a high EPC
                EpcConfirmation.No => "Homeowner disagrees with rating",
                EpcConfirmation.Unknown => "Homeowner unsure",
                null => "",
                _ => throw new ArgumentOutOfRangeException("request.EpcConfirmation", "Unrecognised EpcConfirmation value: " + request.EpcConfirmation),
            };
            EpcLodgementDate = request.EpcLodgementDate?.ToString("yyyy-MM-dd HH:mm:ss");
            OffGasGrid = request.HasGasBoiler switch
            {
                HasGasBoiler.No => "yes",
                HasGasBoiler.Yes => "no",
                _ => throw new ArgumentOutOfRangeException("request.HasGasBoiler", "Unrecognised HasGasBoiler value: " + request.HasGasBoiler)
            };
            HouseholdIncome = request.IncomeBand switch
            {
                IncomeBand.UnderOrEqualTo31000 => "Below £31k",
                IncomeBand.GreaterThan31000 => "£31k or above",
                IncomeBand.UnderOrEqualTo34500 => "Below £34.5k",
                IncomeBand.GreaterThan34500 => "£34.5k or above",
                _ => throw new ArgumentOutOfRangeException("request.IncomeBand", "Unrecognised IncomeBand value: " + request.IncomeBand)
            };
            EligiblePostcode = request.IsLsoaProperty;
            Tenure = "Owner";
        }
    }
}
