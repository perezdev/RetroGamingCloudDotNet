using System.Configuration;

namespace RetroGamingCloudDotNet
{
    public static class Configuration
    {
        public static string GetApiPrefix()
        {
            return ConfigurationManager.AppSettings["ApiPrefix"].ToString().TrimEnd('/');
        }
    }
}
