using Newtonsoft.Json;

namespace Zephyr.MatchV5
{ 

    public class RuneStyle
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("selections")]
        public List<Selection> Selections { get; set; }

        [JsonProperty("style")]
        public int Style { get; set; }
    }

}