using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RetroGamingCloudDotNet
{
    public class GameMedia
    {
        [JsonIgnore]
        private const string MediaGameIdUrl = "/game/{0}/media";

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public int GameId { get; set; }
        [JsonProperty(PropertyName = "created_by")]
        public string CreatedBy { get; set; }
        [JsonProperty(PropertyName = "votes")]
        public int Votes { get; set; }
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? Created { get; set; }
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? Updated { get; set; }
        [JsonIgnore]
        private Bitmap _MediaBitmap = null;
        [JsonIgnore]
        public Bitmap MediaBitmap
        {
            get
            {
                return _MediaBitmap = GetMediaBitmap(); ;
            }
            set => _MediaBitmap = value;
        }

        public static List<GameMedia> GetMediaByGameId(int gameId)
        {
            var json = ApiHelper.GetJsonString($"{Configuration.GetApiPrefix()}{string.Format(MediaGameIdUrl, gameId.ToString())}");
            var media = JsonConvert.DeserializeObject<MediaResults>(json);

            return media.Media;
        }
        public Bitmap GetMediaBitmap()
        {
            if (string.IsNullOrEmpty(Url))
                return null;

            using (WebClient client = new WebClient())
            {
                using (Stream s = client.OpenRead(Url))
                    return new Bitmap(s);
            }
        }
    }
    public class MediaResults
    {
        [JsonProperty(PropertyName = "results")]
        public List<GameMedia> Media { get; set; }
    }
}
