﻿namespace HerPublicWebsite.BusinessLogic.Models.Enums;

public enum QuestionFlowStep
{
    Start,
    GasBoiler,
    DirectToEco,
    Country,
    IneligibleWales,
    IneligibleScotland,
    IneligibleNorthernIreland,
    OwnershipStatus,
    IneligibleTenure,
    Address,
    SelectAddress,
    ReviewEpc,
    ManualAddress,
    SelectLocalAuthority,
    ConfirmLocalAuthority,
    NotTakingPart,
    HouseholdIncome,
    CheckAnswers,
    Eligible,
    Confirmation,
    Ineligible,
    NoConsent
}
