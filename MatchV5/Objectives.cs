using Newtonsoft.Json;

namespace Zephyr.MatchV5
{ 

    public class Objectives
    {
        [JsonProperty("baron")]
        public Baron Baron { get; set; }

        [JsonProperty("champion")]
        public Champion Champion { get; set; }

        [JsonProperty("dragon")]
        public Dragon Dragon { get; set; }

        [JsonProperty("inhibitor")]
        public Inhibitor Inhibitor { get; set; }

        [JsonProperty("riftHerald")]
        public RiftHerald RiftHerald { get; set; }

        [JsonProperty("tower")]
        public Tower Tower { get; set; }
    }

}