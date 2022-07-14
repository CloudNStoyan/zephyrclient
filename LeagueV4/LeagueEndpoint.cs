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

        public async Task<string> GetSummoner
    }
}
