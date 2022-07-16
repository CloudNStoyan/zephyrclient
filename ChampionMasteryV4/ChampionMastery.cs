﻿using Newtonsoft.Json;

namespace Zephyr.ChampionMasteryV4;
public class ChampionMastery
{
    [JsonProperty("championId")]
    public int ChampionId { get; set; }

    [JsonProperty("championLevel")]
    public int ChampionLevel { get; set; }

    [JsonProperty("championPoints")]
    public int ChampionPoints { get; set; }

    [JsonProperty("lastPlayTime")]
    public long LastPlayTime { get; set; }

    [JsonProperty("championPointsSinceLastLevel")]
    public int ChampionPointsSinceLastLevel { get; set; }

    [JsonProperty("championPointsUntilNextLevel")]
    public int ChampionPointsUntilNextLevel { get; set; }

    [JsonProperty("chestGranted")]
    public bool ChestGranted { get; set; }

    [JsonProperty("tokensEarned")]
    public int TokensEarned { get; set; }

    [JsonProperty("summonerId")]
    public string SummonerId { get; set; } = null!;
}
