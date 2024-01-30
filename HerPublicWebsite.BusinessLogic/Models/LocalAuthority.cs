using HerPublicWebsite.BusinessLogic.Models.Enums;

namespace HerPublicWebsite.BusinessLogic.Models;
public enum IncomeThreshold
{
    _31000,
    _34500
}
public class LocalAuthority
{
    public string CustodianCode { get; set; }
    public string Name { get; set; }
    public Hug2Status Status { get; set; }
    public string WebsiteUrl { get; set; }
    public Consortium? Consortium { get; set; }
    public string? ConsortiumCode { get; set; }
    public IncomeThreshold IncomeThreshold { get; set; }
}