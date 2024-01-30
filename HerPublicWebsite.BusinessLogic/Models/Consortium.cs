namespace HerPublicWebsite.BusinessLogic.Models;

public class Consortium
{
    public string ConsortiumCode { get; set; }
    public string Name { get; set; }
    public List<LocalAuthority> LocalAuthorities { get; set; }
}
