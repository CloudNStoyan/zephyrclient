using Newtonsoft.Json;

namespace Zephyr.SummonerV4
{
    public class Summoner
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("accountId")]
        public string AccountId { get; set; } = null!;

        [JsonProperty("puuid")] 
        public string Puuid { get; set; } = null!;

        [JsonProperty("name")] 
        public string Name { get; set; } = null!;

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
