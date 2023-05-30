﻿using GovUkDesignSystem.Attributes.ValidationAttributes;
using HerPublicWebsite.Models.Enums;

using IncomeBandEnum = HerPublicWebsite.BusinessLogic.Models.Enums.IncomeBand;

namespace HerPublicWebsite.Models.Questionnaire;

public class IneligibleViewModel : QuestionFlowViewModel
{
    [GovUkValidateRequired(ErrorMessageIfMissing = "Select whether you would like to be contacted about future grants")]
    public YesOrNo? CanContactByEmailAboutFutureSchemes { get; set; }

    [GovUkValidateRequiredIf(ErrorMessageIfMissing = "Enter your email address", IsRequiredPropertyName = nameof(IsEmailAddressRequired))]
    public string EmailAddress { get; set; }

    public bool IsEmailAddressRequired => CanContactByEmailAboutFutureSchemes is YesOrNo.Yes;

    public bool FoundEpcIsTooHigh { get; set; }

    public IncomeBandEnum? IncomeBand { get; set; }

    public string LocalAuthorityName { get; set; }

    public string LocalAuthorityWebsite { get; set; }

    public bool Submitted { get; set; }
}
