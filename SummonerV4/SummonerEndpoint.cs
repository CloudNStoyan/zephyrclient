using Newtonsoft.Json;

namespace Zephyr.SummonerV4
{
    public class SummonerEndpoint
    {
        private HttpClient HttpClient { get; }
        private readonly string BaseUrl;

        public SummonerEndpoint(HttpClient httpClient, Region region)
        {
            this.HttpClient = httpClient;
            this.BaseUrl = Utils.GenerateBaseUrlWithRegion(region) + "summoner/v4/summoners/";
        }

        /// <summary>
        /// Get a summoner by account ID.
        /// </summary>
        public async Task<Summoner?> GetSummonerByAccountId(string accountId)
        {
            string requestUrl = $"{BaseUrl}by-account/{accountId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(json);
        }

        /// <summary>
        /// Get a summoner by summoner name.
        /// </summary>
        public async Task<Summoner?> GetSummonerByName(string summonerName)
        {
            string requestUrl = $"{BaseUrl}by-name/{summonerName}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(json);
        }

        /// <summary>
        /// Get a summoner by PUUID.
        /// </summary>
        public async Task<Summoner?> GetSummonerByPuuid(string puuid)
        {
            string requestUrl = $"{BaseUrl}by-puuid/{puuid}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(json);
        }

        /// <summary>
        /// Get a summoner by summoner ID.
        /// </summary>
        public async Task<Summoner?> GetSummonerBySummonerId(string summonerId)
        {
            string requestUrl = $"{BaseUrl}{summonerId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(json);
        }
    }
}
