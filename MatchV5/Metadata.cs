using Newtonsoft.Json; 

namespace Zephyr.MatchV5
{ 

    public class Metadata
    {
        [JsonProperty("dataVersion")]
        public string DataVersion { get; set; }

        [JsonProperty("matchId")]
        public string MatchId { get; set; }

        [JsonProperty("participants")]
        public List<string> Participants { get; set; }
    }

}