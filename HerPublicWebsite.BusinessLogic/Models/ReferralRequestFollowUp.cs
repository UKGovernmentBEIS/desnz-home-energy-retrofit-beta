namespace HerPublicWebsite.BusinessLogic.Models;

public class ReferralRequestFollowUp
{
    public int Id { get; set; }
    public ReferralRequest ReferralRequest { get; set; }
    public bool WasFollowedUp { get; set; }
    public DateTime DateOfFollowUpResponse { get; set; }
    public ReferralRequestFollowUp()
    {
    }
}
