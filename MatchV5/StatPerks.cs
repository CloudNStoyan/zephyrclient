using Newtonsoft.Json;

namespace Zephyr.MatchV5
{
    public class StatPerks
    {
        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("flex")]
        public int Flex { get; set; }

        [JsonProperty("offense")]
        public int Offense { get; set; }
    }

}