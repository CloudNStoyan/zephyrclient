using Newtonsoft.Json;

namespace Zephyr.MatchV5 
{
    public class Match
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }

}