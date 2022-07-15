using Newtonsoft.Json;

namespace Zephyr.MatchV5
{
    public class MatchEndpoint
    {
        private HttpClient HttpClient { get; }
        private const string BaseUrl = "https://europe.api.riotgames.com/lol/match/v5/matches/";

        public MatchEndpoint(HttpClient httpClient)
        {
            this.HttpClient = httpClient;
        }

        public async Task<string[]?> GetMatchIdsByPuuid(string puuid, MatchQueryParams? queryParams = null)
        {
            string? queries = queryParams?.ToUrlQuery();

            string requestUrl = $"{BaseUrl}by-puuid/{puuid}/ids{queries}";

            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<string[]>(json);
        }

        public async Task<Match?> GetMatchByMatchId(string matchId)
        {
            string requestUrl = $"{BaseUrl}{matchId}";

            var response = await HttpClient.GetAsync(requestUrl);

            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Match>(json);
        }
    }
}
