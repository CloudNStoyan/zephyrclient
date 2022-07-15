using Newtonsoft.Json; 

namespace Zephyr.MatchV5
{
    public class Ban
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
    }

}