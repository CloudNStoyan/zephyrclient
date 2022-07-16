using Newtonsoft.Json;

namespace Zephyr.LeagueV4
{
    public class LeagueEndpoint
    {
        private HttpClient HttpClient { get; }
        private readonly string BaseUrl;

        public LeagueEndpoint(HttpClient httpClient, Region region)
        {
            this.HttpClient = httpClient;
            this.BaseUrl = Utils.GenerateBaseUrlWithRegion(region) + "league/v4/";
        }

        /// <summary>
        /// Get league entries in all queues for a given summoner ID.
        /// </summary>
        public async Task<League[]?> GetLeagueEntriesBySummonerId(string summonerId)
        {
            string requestUrl = $"{BaseUrl}entries/by-summoner/{summonerId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<League[]>(json);
        }
    }
}
