using Newtonsoft.Json;

namespace Zephyr.LeagueV4
{
    public class LeagueEndpoint
    {
        private HttpClient HttpClient { get; }
        private const string BaseUrl = "https://eun1.api.riotgames.com/lol/league/v4/";

        public LeagueEndpoint(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<League[]?> GetLeagueEntriesBySummonerId(string summonerId)
        {
            string requestUrl = $"{BaseUrl}entries/by-summoner/{summonerId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<League[]>(json);
        }
    }
}
