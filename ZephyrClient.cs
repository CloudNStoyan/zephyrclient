using Zephyr.SummonerV4;

namespace Zephyr
{
    public class ZephyrClient
    {
        public SummonerEndpoint Summoner { get; }
        public ZephyrClient(string apiKey)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-Riot-Token", apiKey);

            this.Summoner = new SummonerEndpoint(httpClient);
        }
    }
}