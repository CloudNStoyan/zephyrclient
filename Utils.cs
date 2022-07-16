namespace Zephyr;
public static class Utils
{
    public static string GenerateBaseUrlWithRegion(Region region) =>
        $"https://{region.ToString().ToLower()}.api.riotgames.com/lol/";
    public static string GenerateBaseUrlWithRegion(MatchRegion region) =>
        $"https://{region.ToString().ToLower()}.api.riotgames.com/lol/";
}
