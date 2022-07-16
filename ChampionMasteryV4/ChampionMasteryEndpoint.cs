using Newtonsoft.Json;

namespace Zephyr.ChampionMasteryV4
{
    public class ChampionMasteryEndpoint
    {
        private HttpClient HttpClient { get; }
        private readonly string BaseUrl;

        public ChampionMasteryEndpoint(HttpClient httpClient, Region region)
        {
            this.HttpClient = httpClient;
            this.BaseUrl = Utils.GenerateBaseUrlWithRegion(region) + "champion-mastery/v4/";
        }

        /// <summary>
        /// Get all champion mastery entries sorted by number of champion points descending.
        /// </summary>
        public async Task<ChampionMastery[]?> GetChampionMasteriesBySummonerId(string summonerId)
        {
            string requestUrl = $"{this.BaseUrl}champion-masteries/by-summoner/{summonerId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ChampionMastery[]>(json);
        }

        /// <summary>
        /// Get a champion mastery by player ID and champion ID.
        /// </summary>
        public async Task<ChampionMastery?> GetChampionMastery(string summonerId, int championId)
        {
            string requestUrl = $"{this.BaseUrl}champion-masteries/by-summoner/{summonerId}/by-champion/{championId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ChampionMastery>(json);
        }

        /// <summary>
        /// Get a player's total champion mastery score, which is the sum of individual
        /// champion mastery levels.
        /// </summary>
        public async Task<int?> GetMasteryScore(string summonerId)
        {
            string requestUrl = $"{this.BaseUrl}scores/by-summoner/{summonerId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<int?>(json);
        }
    }
}