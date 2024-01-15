using HerPublicWebsite.BusinessLogic.Extensions;
using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;

using HerPublicWebsite.BusinessLogic.Models;

namespace HerPublicWebsite.BusinessLogic.Services.ReferralFollowUpManager;

public interface IReferralFollowUpService
{
    public Task GenerateAndSendFollowUpEmail(ReferralRequest referralRequest);
    public Task ConfirmFollowUp(string token);
    public Task NoFollowUp(string token);
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

    // Check whether a postcode is in the list of eligible postcodes found on this page
    // https://www.gov.uk/government/publications/home-upgrade-grant-phase-2 in the "HUG: Phase 2 - eligible postcodes"
    // spreadsheet.
    public async Task GenerateAndSendFollowUpEmail(ReferralRequest referralRequest)
    {
        string token = GenerateFollowUpToken();
        string confirmFollowUpLink = "someroute/ReferralFollowUp/Yes?token=" + token;
        string noFollowUpLink = "someroute/ReferralFollowUp/No?token=" + token;
        
        await dataAccessProvider.AddReferralFollowUpToken(referralRequest, token );

        this.emailSender.SendFollowUpEmail(
            referralRequest.ContactEmailAddress,
             referralRequest.FullName,
              referralRequest.ReferralCode,
               referralRequest.CustodianCode,
                referralRequest.RequestDate,
                 confirmFollowUpLink, 
                 noFollowUpLink);
    }

    public async Task ConfirmFollowUp(string token)
    {
        // What should we do if the code has already been used?
        if (await dataAccessProvider.hasReferralFollowUpCodeBeenUsed(token)){
            throw new InvalidOperationException();
        }
        await dataAccessProvider.MarkFollowUpTokenAsUsedWithResponse(token, wasFollowedUp=true);
    }

    public async Task NoFollowUp(string token)
    {
        // What should we do if the code has already been used?
        if (await dataAccessProvider.hasReferralFollowUpCodeBeenUsed(token)){
            throw new InvalidOperationException();
        }
        await dataAccessProvider.MarkFollowUpTokenAsUsedWithResponse(token, wasFollowedUp=false);
    }

    private string GenerateFollowUpToken()
    {
        return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
    }
}
