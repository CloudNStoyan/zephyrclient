using Newtonsoft.Json;
using Zephyr.Static.Champion;

namespace Zephyr.Static;
public class DDragon
{
    private readonly HttpClient Client = new();
    public StaticChampionEndpoint Champion { get; }

    public DDragon()
    {
        this.Champion = new StaticChampionEndpoint(this.Client);
    }

    public async Task<string[]?> GetVersions()
    {
        const string versionsUrl = "https://ddragon.leagueoflegends.com/api/versions.json";
        var response = await this.Client.GetAsync(versionsUrl);
        string json = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<string[]>(json);
    }
}
