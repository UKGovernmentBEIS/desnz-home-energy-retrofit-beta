﻿using System;
using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.Models.Enums;

namespace Tests.Builders;

public class ReferralRequestBuilder
{
    private ReferralRequest referralRequest;

    public ReferralRequestBuilder(int id)
    {
        referralRequest = new ReferralRequest
        {
            AddressLine1 = $"Address {id} line 1",
            AddressLine2 = $"Address {id} line 2",
            AddressTown = $"Town{id}",
            AddressCounty = $"County{id}",
            AddressPostcode = $"AL{id:D2} 1RS",
            CustodianCode = "114",
            EpcRating = EpcRating.E,
            HasGasBoiler = HasGasBoiler.No,
            Id = id,
            IncomeBand = IncomeBand.UnderOrEqualTo31000,
            Uprn = $"100 111 222 {id:D3}",
            ReferralWrittenToCsv = false,
            RequestDate = new DateTime(2023, 01, 01, 13, 00, id),
            IsLsoaProperty = false,
            ContactEmailAddress = $"contact{id}@example.com",
            FullName = $"Full Name{id}",
            ContactTelephone = $"{id:D5} 123456"
        };
    }
    public ReferralRequest Build()
    {
        return referralRequest;
    }

    public ReferralRequestBuilder WithReferralCreated(bool referralCreated)
    {
        referralRequest.ReferralWrittenToCsv = referralCreated;
        return this;
    }

    public ReferralRequestBuilder WithRequestDate(DateTime requestDate)
    {
        referralRequest.RequestDate = requestDate;
        return this;
    }

    public ReferralRequestBuilder WithCustodianCode(string custodianCode)
    {
        referralRequest.CustodianCode = custodianCode;
        return this;
    }

    public ReferralRequestBuilder WithHasGasBoiler(HasGasBoiler hasGasBoiler)
    {
        referralRequest.HasGasBoiler = hasGasBoiler;
        return this;
    }

    public ReferralRequestBuilder WithIncomeBand(IncomeBand incomeBand)
    {
        referralRequest.IncomeBand = incomeBand;
        return this;
    }

    public ReferralRequestBuilder WithFullName(string fullName)
    {
        referralRequest.FullName = fullName;
        return this;
    }

    public ReferralRequestBuilder WithTelephone(string telephone)
    {
        referralRequest.ContactTelephone = telephone;
        return this;
    }
}
