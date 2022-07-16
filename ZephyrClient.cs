using Zephyr.ChampionMasteryV4;
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
        public ChampionMasteryEndpoint ChampionMastery { get; }

        public ZephyrClient(string apiKey, Region region, MatchRegion matchRegion)
        {
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("X-Riot-Token", apiKey);

            this.Summoner = new SummonerEndpoint(httpClient, region);
            this.League = new LeagueEndpoint(httpClient, region);
            this.Match = new MatchEndpoint(httpClient, matchRegion);
            this.ChampionMastery = new ChampionMasteryEndpoint(httpClient, region);
        }
    }
}