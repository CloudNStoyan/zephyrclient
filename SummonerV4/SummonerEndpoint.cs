using Newtonsoft.Json;

namespace Zephyr.SummonerV4
{
    public class SummonerEndpoint
    {
        private HttpClient HttpClient { get; }
        private const string BaseUrl = "https://eun1.api.riotgames.com/lol/summoner/v4/summoners/";

        public SummonerEndpoint(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<Summoner?> GetSummonerByAccountId(string accountId)
        {
            string requestUrl = $"{BaseUrl}by-account/{accountId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(json);
        }

        public async Task<Summoner?> GetSummonerByName(string summonerName)
        {
            string requestUrl = $"{BaseUrl}by-name/{summonerName}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(json);
        }

        public async Task<Summoner?> GetSummonerByPuuid(string puuid)
        {
            string requestUrl = $"{BaseUrl}by-puuid/{puuid}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(json);
        }

        public async Task<Summoner?> GetSummonerBySummonerId(string summonerId)
        {
            string requestUrl = $"{BaseUrl}{summonerId}";
            var response = await HttpClient.GetAsync(requestUrl);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(json);
        }
    }
}
