using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zephyr.Static.Champion;
public class StaticChampionEndpoint
{
    private HttpClient HttpClient { get; }
    private const string CdnUrl = "https://ddragon.leagueoflegends.com/cdn/";

    public StaticChampionEndpoint(HttpClient httpClient)
    {
        this.HttpClient = httpClient;
    }

    public async Task<ChampionFull?[]> GetAllChampionFull(string version, Language language = Language.en_US)
    {
        string championFullUrl = $"{CdnUrl}{version}/data/{language}/championFull.json";
        var response = await this.HttpClient.GetAsync(championFullUrl);

        string json = await response.Content.ReadAsStringAsync();

        var responseObject = JObject.Parse(json);

        var championsFull = responseObject["data"].Values().ToArray()
            .Select(token => JsonConvert.DeserializeObject<ChampionFull>(token.ToString()));

        return championsFull.ToArray();
    }

    public async Task<ChampionShort?[]> GetAllChampionShort(string version, Language language = Language.en_US)
    {
        string championShortUrl = $"{CdnUrl}{version}/data/{language}/champion.json";
        var response = await this.HttpClient.GetAsync(championShortUrl);

        string json = await response.Content.ReadAsStringAsync();

        var responseObject = JObject.Parse(json);

        var championsShort = responseObject["data"].Values().ToArray()
            .Select(token => JsonConvert.DeserializeObject<ChampionShort>(token.ToString()));

        return championsShort.ToArray();
    }
}
