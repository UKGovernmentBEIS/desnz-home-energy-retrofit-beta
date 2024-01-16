using HerPublicWebsite.BusinessLogic.ExternalServices.EmailSending;

using HerPublicWebsite.BusinessLogic.Models;

namespace HerPublicWebsite.BusinessLogic.Services.ReferralFollowUpManager;

public interface IReferralFollowUpService
{
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

    public async Task GenerateAndSendFollowUpEmail(ReferralRequest referralRequest)
    {
        string token = GenerateFollowUpToken();

        string followUpLink = "https://localhost:5001/referral-follow-up/respond-page/" + token;
        
        ReferralRequestFollowUp referralRequestFollowUp = new ReferralRequestFollowUp(referralRequest, token);
        await dataAccessProvider.AddReferralFollowUpToken(referralRequestFollowUp);

        this.emailSender.SendFollowUpEmail(
            referralRequest,
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
