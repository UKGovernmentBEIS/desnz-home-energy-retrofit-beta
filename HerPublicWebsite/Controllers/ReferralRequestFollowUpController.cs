using System.Threading.Tasks;
using HerPublicWebsite.Models.ReferralRequestFollowUp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using HerPublicWebsite.BusinessLogic.Services.ReferralFollowUpManager;
using HerPublicWebsite.Models.Enums;
using System;
using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using HerPublicWebsite.BusinessLogic.Models;

namespace HerPublicWebsite.Controllers;

[Route("referral-follow-up")]
public class ReferralRequestFollowUpController : Controller
{
    private readonly IReferralFollowUpService referralFollowUpService;
    private readonly ILogger logger;

    public ReferralRequestFollowUpController(
        IReferralFollowUpService referralFollowUpService,
        ILogger<QuestionnaireController> logger
    )
    {
        this.referralFollowUpService = referralFollowUpService;
        this.logger = logger;
    }

    [HttpGet("test")]
    public async void Test()
    {   
        ReferralRequest referralRequest = await referralFollowUpService.Test();
        Console.WriteLine(referralRequest.ContactEmailAddress);
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
        Console.WriteLine(viewModel);
        Console.WriteLine(viewModel.Token);
        Console.WriteLine(viewModel.HasFollowedUp);
        await referralFollowUpService.RecordFollowUpResponseForToken(viewModel!.Token, viewModel.HasFollowedUp is YesOrNo.Yes);
        return RedirectToAction(nameof(ResponseRecorded), "ReferralRequestFollowUp");
    }

    [HttpGet("response-recorded")]
    public IActionResult ResponseRecorded()
    {
         return View("ReferralRequestFollowUpResponseRecorded");
    }
}
