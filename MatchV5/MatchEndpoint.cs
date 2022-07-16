using Newtonsoft.Json;

namespace Zephyr.MatchV5
{
    public class MatchEndpoint
    {
        private HttpClient HttpClient { get; }
        private readonly string BaseUrl;

        public MatchEndpoint(HttpClient httpClient, MatchRegion region)
        {
            this.HttpClient = httpClient;
            this.BaseUrl = Utils.GenerateBaseUrlWithRegion(region) + "match/v5/matches/";
        }

        /// <summary>
        /// Get a list of match ids by puuid.
        /// </summary>
        public async Task<string[]?> GetMatchIdsByPuuid(string puuid, MatchQueryParams? queryParams = null)
        {
            string? queries = queryParams?.ToUrlQuery();

            string requestUrl = $"{BaseUrl}by-puuid/{puuid}/ids{queries}";

            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<string[]>(json);
        }

        /// <summary>
        /// Get a match by match id.
        /// </summary>
        public async Task<Match?> GetMatchByMatchId(string matchId)
        {
            string requestUrl = $"{BaseUrl}{matchId}";

            var response = await HttpClient.GetAsync(requestUrl);

            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Match>(json);
        }
    }
}
