using Zephyr.LeagueV4;
using Zephyr.MatchV5;
using Zephyr.SummonerV4;

namespace Zephyr
{
    public class ZephyrClient
    {
        public SummonerEndpoint Summoner { get; }

        public LeagueEndpoint League { get; }

        public MatchEndpoint Match { get; }

        public ZephyrClient(string apiKey)
        {
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("X-Riot-Token", apiKey);

            this.Summoner = new SummonerEndpoint(httpClient);
            this.League = new LeagueEndpoint(httpClient);
            this.Match = new MatchEndpoint(httpClient);
        }
    }
}