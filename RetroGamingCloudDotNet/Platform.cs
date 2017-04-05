using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RetroGamingCloudDotNet
{
    public class Platform
    {
        [JsonIgnore]
        private const string PlatformUrl = "/platform";

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? Created { get; set; }
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? Updated { get; set; }

        public static List<Platform> GetPlatforms()
        {
            var json = ApiHelper.GetJsonString($"{Configuration.GetApiPrefix()}{PlatformUrl}");
            var platforms = JsonConvert.DeserializeObject<PlatformResults>(json);

            return platforms.Platforms;
        }
    }
    public class PlatformResults
    {
        [JsonProperty(PropertyName = "results")]
        public List<Platform> Platforms { get; set; }
    }
}
