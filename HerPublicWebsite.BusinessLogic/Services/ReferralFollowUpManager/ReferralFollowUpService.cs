using System.Security.Cryptography.X509Certificates;
using HerPublicWebsite.BusinessLogic.Extensions;
using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;

using HerPublicWebsite.BusinessLogic.Models;

namespace HerPublicWebsite.BusinessLogic.Services.ReferralFollowUpManager;

public interface IReferralFollowUpService
{
    public Task<ReferralRequest> Test();
    public Task GenerateAndSendFollowUpEmail(ReferralRequest referralRequest);
    public ReferralRequestFollowUp GetReferralRequestFollowUpByToken(string token);
    public Task RecordFollowUpResponseForToken(string token, bool hasFollowedUp);
}

public class ReferralFollowUpService : IReferralFollowUpService
{
    private readonly IEmailSender emailSender;
    private readonly IDataAccessProvider dataAccessProvider;
    public ReferralFollowUpService(IEmailSender emailSender, IDataAccessProvider dataAccessProvider)
    {
        this.emailSender = emailSender;
        this.dataAccessProvider = dataAccessProvider;
    }
    public async Task<ReferralRequest> Test()
    {
        var test = await dataAccessProvider.GetUnsubmittedReferralRequestsAsync();
        return test[0];
    }

    public async Task GenerateAndSendFollowUpEmail(ReferralRequest referralRequest)
    {
        string token = GenerateFollowUpToken();
        string followUpLink = "someroute/ReferralFollowUp/Yes?token=" + token;
        
        ReferralRequestFollowUp referralRequestFollowUp = new ReferralRequestFollowUp(referralRequest, token);
        await dataAccessProvider.AddReferralFollowUpToken(referralRequestFollowUp);

        this.emailSender.SendFollowUpEmail(
            referralRequest.ContactEmailAddress,
             referralRequest.FullName,
              referralRequest.ReferralCode,
               referralRequest.CustodianCode,
                referralRequest.RequestDate,
                 followUpLink);
    }
    public ReferralRequestFollowUp GetReferralRequestFollowUpByToken(string token)
    {
        return dataAccessProvider.GetReferralFollowUpByToken(token);
    }
    public async Task RecordFollowUpResponseForToken(string token, bool hasFollowedUp)
    {
        ReferralRequestFollowUp referralRequestFollowUp = dataAccessProvider.GetReferralFollowUpByToken(token);
        // What should we do if the code has already been used?
        if (referralRequestFollowUp.WasFollowedUp is not null){
            throw new InvalidOperationException();
        }
        await dataAccessProvider.UpdateReferralFollowUpByTokenWithWasFollowedUp(token, hasFollowedUp);
    }

    private string GenerateFollowUpToken()
    {
        return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
    }
}
