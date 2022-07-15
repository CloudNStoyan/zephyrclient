using Newtonsoft.Json;

namespace Zephyr.MatchV5
{
    public class Baron
    {
        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }
    }

}