using System.Net;

namespace RetroGamingCloudDotNet
{
    public static class ApiHelper
    {
        public static string GetJsonString(string url)
        {
            string json = string.Empty;

            using(WebClient client = new WebClient())
                json = client.DownloadString(url);

            return json;
        }
    }
}
