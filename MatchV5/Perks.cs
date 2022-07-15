using Newtonsoft.Json;

namespace Zephyr.MatchV5
{
    public class Perks
    {
        [JsonProperty("statPerks")]
        public StatPerks StatPerks { get; set; }

        [JsonProperty("styles")]
        public List<RuneStyle> Styles { get; set; }
    }

}