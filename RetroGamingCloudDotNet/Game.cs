using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RetroGamingCloudDotNet
{
    public class Game
    {
        [JsonIgnore]
        private const string GameIdUrl = "/game";
        [JsonIgnore]
        private const string GameSearchUrl = "/game?name=%{0}%";

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "created_by")]
        public string CreatedBy { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "platform_id")]
        public int PlatformId { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? Created { get; set; }
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? Updated { get; set; }
        [JsonProperty(PropertyName = "platform")]
        public Platform Platform { get; set; }
        public List<GameMedia> Media { get { return Id == 0 ? null : GameMedia.GetMediaByGameId(Id); } }

        public static Game GetById(int id)
        {
            var json = ApiHelper.GetJsonString($"{Configuration.GetApiPrefix()}{GameIdUrl}/{id.ToString()}");
            var game = JsonConvert.DeserializeObject<GameResult>(json);
            
            return game.Game;
        }
        public static List<Game> Search(string gameName)
        {
            var json = ApiHelper.GetJsonString($"{Configuration.GetApiPrefix()}{string.Format(GameSearchUrl, gameName)}");
            var games = JsonConvert.DeserializeObject<GameResults>(json);

            return games.Games;
        }
    }
    public class GameResults
    {
        [JsonProperty(PropertyName = "results")]
        public List<Game> Games { get; set; }
    }
    public class GameResult
    {
        [JsonProperty(PropertyName = "results")]
        public Game Game { get; set; }
    }
}
