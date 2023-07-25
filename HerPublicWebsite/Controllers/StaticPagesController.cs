﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace HerPublicWebsite.Controllers;

public class StaticPagesController : Controller
{
    private readonly IWebHostEnvironment environment;

    public StaticPagesController(IWebHostEnvironment environment)
    {
        this.environment = environment;
    }

    [HttpGet("/")]
    public IActionResult Index()
    {
        if (environment.IsProduction())
        {
            return RedirectToAction(nameof(QuestionnaireController.GasBoiler_Get), "Questionnaire");
        }

        return View("Index");
    }

    [HttpGet("/accessibility-statement")]
    public IActionResult AccessibilityStatement()
    {
        return View("AccessibilityStatement");
    }
    
    [HttpGet("/privacy-policy")]
    public IActionResult PrivacyPolicy()
    {
        return View("PrivacyPolicy");
    }

    [HttpGet("/session-expired")]
    public IActionResult SessionExpired()
    {
        return View("SessionExpired");
    }
}
