using Newtonsoft.Json;

namespace Zephyr.MatchV5
{
    public class Team
    {
        [JsonProperty("bans")]
        public List<Ban> Bans { get; set; }

        [JsonProperty("objectives")]
        public Objectives Objectives { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("win")]
        public bool Win { get; set; }
    }

}