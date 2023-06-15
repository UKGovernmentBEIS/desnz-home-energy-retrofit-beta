namespace HerPublicWebsite.Configuration;

public class DebugInformationConfiguration
{
    public const string ConfigSection = "DebugInformation";
        
    public HtmlDebugInformationConfiguration Html { get; set; }
}

public class HtmlDebugInformationConfiguration
{
    public bool ShowBuildNumber { get; set; }
    public bool ShowServerName { get; set; }
}
