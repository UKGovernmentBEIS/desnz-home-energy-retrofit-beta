﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.Models.Enums;
using HerPublicWebsite.BusinessLogic.Services;
using HerPublicWebsite.ExternalServices.GoogleAnalytics;
using HerPublicWebsite.Models.Questionnaire;
using HerPublicWebsite.Services;
using HerPublicWebsite.Services.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HerPublicWebsite.Controllers;

[Route("questionnaire")]
public class QuestionnaireController : Controller
{
    private readonly IQuestionFlowService questionFlowService;
    private readonly CookieService cookieService;
    private readonly GoogleAnalyticsService googleAnalyticsService;
    private readonly QuestionnaireService questionnaireService;

    public QuestionnaireController(
        IQuestionFlowService questionFlowService,
        CookieService cookieService,
        GoogleAnalyticsService googleAnalyticsService,
        QuestionnaireService questionnaireService)
    {
        this.questionFlowService = questionFlowService;
        this.cookieService = cookieService;
        this.googleAnalyticsService = googleAnalyticsService;
        this.questionnaireService = questionnaireService;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return RedirectToAction(nameof(StaticPagesController.Index), "StaticPages");
    }

    [HttpGet("country/")]
    public IActionResult Country_Get()
    {
        var questionnaire = questionnaireService.GetQuestionnaire();
        var viewModel = new CountryViewModel
        {
            Country = questionnaire.Country,
            BackLink = GetBackUrl(QuestionFlowStep.Country, questionnaire)
        };

        return View("Country", viewModel);
    }

    [HttpPost("country/")]
    public IActionResult Country_Post(CountryViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return Country_Get();
        }

        var questionnaire = questionnaireService.UpdateCountry(viewModel.Country!.Value);
        var nextStep = questionFlowService.NextStep(QuestionFlowStep.Country, questionnaire);

        return RedirectToNextStep(nextStep);
    }

    [HttpGet("service-unsuitable/")]
    public IActionResult ServiceUnsuitable_Get()
    {
        var questionnaire = questionnaireService.GetQuestionnaire();

        var viewModel = new ServiceUnsuitableViewModel
        {
            BackLink = GetBackUrl(QuestionFlowStep.ServiceUnsuitable, questionnaire)
        };

        return View("ServiceUnsuitable", viewModel);
    }

    [HttpGet("ownership-status/")]
    public IActionResult OwnershipStatus_Get()
    {
        var questionnaire = questionnaireService.GetQuestionnaire();

        var viewModel = new OwnershipStatusViewModel()
        {
            OwnershipStatus = questionnaire.OwnershipStatus,
            BackLink = GetBackUrl(QuestionFlowStep.OwnershipStatus, questionnaire)
        };

        return View("OwnershipStatus", viewModel);
    }

    [HttpPost("ownership-status/")]
    public IActionResult OwnershipStatus_Post(OwnershipStatusViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return Country_Get();
        }

        var questionnaire = questionnaireService.UpdateOwnershipStatus(viewModel.OwnershipStatus!.Value);
        var nextStep = questionFlowService.NextStep(QuestionFlowStep.OwnershipStatus, questionnaire);

        return RedirectToNextStep(nextStep);
    }

    [HttpGet("address/")]
    public IActionResult Address_Get()
    {
        var questionnaire = questionnaireService.GetQuestionnaire();

        var viewModel = new AddressViewModel()
        {
            BackLink = GetBackUrl(QuestionFlowStep.Address, questionnaire)
        };

        return View("Address", viewModel);
    }

    [HttpPost("address/")]
    public IActionResult Address_Post(AddressViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return Address_Get();
        }
        var questionnaire = questionnaireService.GetQuestionnaire();
        var nextStep = questionFlowService.NextStep(QuestionFlowStep.Address, questionnaire);
        var forwardArgs = GetActionArgumentsForQuestion(
            nextStep,
            null,
            extraRouteValues: new Dictionary<string, object>
            {
                { "postcode", viewModel.Postcode },
                { "buildingNameOrNumber", viewModel.BuildingNameOrNumber }
            }
        );

        return RedirectToAction(forwardArgs.Action, forwardArgs.Controller, forwardArgs.Values);
    }

    [HttpGet("address/{postcode}/{buildingNameOrNumber}")]
    public IActionResult SelectAddress_Get(string postcode, string buildingNameOrNumber)
    {

        //TODO (BEISHER-248): Replace with call to OS Places API to get actual results
        var viewModel = new SelectAddressViewModel()
        {
            Addresses = new List<OsPlacesResult>
            {
                new() {
                    Address = "82 Test Place",
                    Uprn = "1337"
                },
                new ()
                {
                    Address = "23 Jellyifsh Place",
                    Uprn = "420"
                }
            }
        };

        TempData["Addresses"] = JsonSerializer.Serialize(viewModel.Addresses);

        return View("SelectAddress", viewModel);
    }

    [HttpPost("address/{postcode}/{buildingNameOrNumber}")]
    public IActionResult SelectAddress_Post(SelectAddressViewModel viewModel, string postcode, string buildingNameOrNumber)
    {
        if (!ModelState.IsValid)
        {
            return SelectAddress_Get(postcode, buildingNameOrNumber);
        }
        
        try
        {
            var addressResults = JsonSerializer.Deserialize<List<OsPlacesResult>>(TempData["Addresses"] as string ?? throw new InvalidOperationException());
            var questionnaire = questionnaireService.UpdateAddress(addressResults[Convert.ToInt32(viewModel.Index)]);

            var nextStep = questionFlowService.NextStep(QuestionFlowStep.SelectAddress, questionnaire);
            return RedirectToNextStep(nextStep);
        }
        catch (Exception e)
        {
            var questionnaire = questionnaireService.GetQuestionnaire();
            var nextStep = questionFlowService.PreviousStep(QuestionFlowStep.SelectAddress, questionnaire);
            return RedirectToNextStep(nextStep);
        }
    }

    [HttpGet("address/manual")]
    public IActionResult ManualAddress_Get()
    {
        return RedirectToAction(nameof(StaticPagesController.Index), "StaticPages");
    }

    [HttpGet("boiler")]
    public IActionResult GasBoiler_Get()
    {
        return RedirectToAction(nameof(StaticPagesController.Index), "StaticPages");
    }


    private string GetBackUrl(
        QuestionFlowStep currentStep,
        Questionnaire questionnaire = null,
        QuestionFlowStep? entryPoint = null)
    {
        var backStep = questionFlowService.PreviousStep(currentStep, questionnaire, entryPoint);
        var args = GetActionArgumentsForQuestion(backStep, entryPoint);
        return Url.Action(args.Action, args.Controller, args.Values);
    }

    private RedirectToActionResult RedirectToNextStep(QuestionFlowStep nextStep, QuestionFlowStep? entryPoint = null)
    {
        var forwardArgs = GetActionArgumentsForQuestion(nextStep, entryPoint);
        return RedirectToAction(forwardArgs.Action, forwardArgs.Controller, forwardArgs.Values);
    }

    private PathByActionArguments GetActionArgumentsForQuestion(
            QuestionFlowStep question,
            QuestionFlowStep? entryPoint = null,
            IDictionary<string, object> extraRouteValues = null)
    {
        return question switch
        {
            QuestionFlowStep.Start => new PathByActionArguments(nameof(Index), "Questionnaire"),
            QuestionFlowStep.Country => new PathByActionArguments(nameof(Country_Get), "Questionnaire", GetRouteValues(extraRouteValues)),
            QuestionFlowStep.ServiceUnsuitable => new PathByActionArguments(nameof(ServiceUnsuitable_Get), "Questionnaire", GetRouteValues(extraRouteValues)),
            QuestionFlowStep.OwnershipStatus => new PathByActionArguments(nameof(OwnershipStatus_Get), "Questionnaire", GetRouteValues(extraRouteValues)),
            QuestionFlowStep.Address => new PathByActionArguments(nameof(Address_Get), "Questionnaire", GetRouteValues(extraRouteValues)),
            QuestionFlowStep.SelectAddress => new PathByActionArguments(nameof(SelectAddress_Get), "Questionnaire", GetRouteValues(extraRouteValues)),
            QuestionFlowStep.GasBoiler => new PathByActionArguments(nameof(GasBoiler_Get), "Questionnaire", GetRouteValues(extraRouteValues)),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private RouteValueDictionary GetRouteValues(
        IDictionary<string, object> extraRouteValues,
        QuestionFlowStep? entryPoint = null)
    {
        // If entryPoint is null then it won't appear in the URL
        var ret = new RouteValueDictionary { { "entryPoint", entryPoint } };

        if (extraRouteValues != null)
        {
            foreach (var extraRouteValue in extraRouteValues)
            {
                ret[extraRouteValue.Key] = extraRouteValue.Value;
            }
        }

        return ret;
    }

    private class PathByActionArguments
    {
        public readonly string Action;
        public readonly string Controller;
        public readonly RouteValueDictionary Values;

        public PathByActionArguments(string action, string controller, RouteValueDictionary values = null)
        {
            Action = action;
            Controller = controller;
            Values = values;
        }
    }
}
