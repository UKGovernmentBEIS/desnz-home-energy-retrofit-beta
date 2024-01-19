using System.Threading.Tasks;
using HerPublicWebsite.Models.ReferralRequestFollowUp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using HerPublicWebsite.BusinessLogic.Services.ReferralFollowUps;
using HerPublicWebsite.Models.Enums;
using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.Services.RegularJobs;

namespace HerPublicWebsite.Controllers;

[Route("referral-follow-up")]
public class ReferralRequestFollowUpController : Controller
{
    private readonly IReferralFollowUpService referralFollowUpService;
    private readonly IRegularJobsService regularJobsService;

    public ReferralRequestFollowUpController(
        IReferralFollowUpService referralFollowUpService,
        IRegularJobsService regularJobsService
    )
    {
        this.referralFollowUpService = referralFollowUpService;
        this.regularJobsService = regularJobsService;
    }


    [HttpGet("test")]
    public void test()
    {
        regularJobsService.RunWeeklyTasksAsync();
    }

    [HttpGet("already-responded")]
    public IActionResult AlreadyResponded()
    {
         return View("ReferralRequestFollowUpAlreadyResponded");
    }

    [HttpGet("respond-page/{token}")]
    public IActionResult RespondPage_Get(string token)
    {
        ReferralRequestFollowUp referralRequestFollowUp = referralFollowUpService.GetReferralRequestFollowUpByToken(token);
        if (referralRequestFollowUp.WasFollowedUp is not null) {
            return RedirectToAction(nameof(AlreadyResponded), "ReferralRequestFollowUp");
        } else {  
            var viewModel = new ReferralRequestFollowUpResponsePageViewModel
            {
                Token = token,
                ReferralCode = referralRequestFollowUp.ReferralRequest.ReferralCode, 
                RequestDate = referralRequestFollowUp.ReferralRequest.RequestDate
            };
            return View("ReferralRequestFollowUpResponsePage", viewModel);
        }
    }

    [HttpPost("respond-page/{token}")]
    public async Task<IActionResult> RespondPage_Post(ReferralRequestFollowUpResponsePageViewModel viewModel)
    {
        await referralFollowUpService.RecordFollowUpResponseForToken(viewModel!.Token, viewModel.HasFollowedUp is YesOrNo.Yes);
        return RedirectToAction(nameof(ResponseRecorded), "ReferralRequestFollowUp");
    }

    [HttpGet("response-recorded")]
    public IActionResult ResponseRecorded()
    {
         return View("ReferralRequestFollowUpResponseRecorded");
    }
}
