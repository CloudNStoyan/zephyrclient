using Newtonsoft.Json;

namespace Zephyr.Static.Champion;
public class ChampionShortImage
{
    [JsonProperty("full")]
    public string Full { get; set; }

    [JsonProperty("sprite")]
    public string Sprite { get; set; }

    [JsonProperty("group")]
    public string Group { get; set; }

    [JsonProperty("x")]
    public int X { get; set; }

    [JsonProperty("y")]
    public int Y { get; set; }

    [JsonProperty("w")]
    public int W { get; set; }

    [JsonProperty("h")]
    public int H { get; set; }
}

public class ChampionShortInfo
{
    [JsonProperty("attack")]
    public int Attack { get; set; }

    [JsonProperty("defense")]
    public int Defense { get; set; }

    [JsonProperty("magic")]
    public int Magic { get; set; }

    [JsonProperty("difficulty")]
    public int Difficulty { get; set; }
}

public class ChampionShort
{
    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("blurb")]
    public string Blurb { get; set; }

    [JsonProperty("info")]
    public ChampionShortInfo Info { get; set; }

    [JsonProperty("image")]
    public ChampionShortImage Image { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }

    [JsonProperty("partype")]
    public string Partype { get; set; }

    [JsonProperty("stats")]
    public Stats Stats { get; set; }
}

public class ChampionShortStats
{
    [JsonProperty("hp")]
    public double Hp { get; set; }

    [JsonProperty("hpperlevel")]
    public int Hpperlevel { get; set; }

    [JsonProperty("mp")]
    public double Mp { get; set; }

    [JsonProperty("mpperlevel")]
    public double Mpperlevel { get; set; }

    [JsonProperty("movespeed")]
    public int Movespeed { get; set; }

    [JsonProperty("armor")]
    public int Armor { get; set; }

    [JsonProperty("armorperlevel")]
    public double Armorperlevel { get; set; }

    [JsonProperty("spellblock")]
    public double Spellblock { get; set; }

    [JsonProperty("spellblockperlevel")]
    public double Spellblockperlevel { get; set; }

    [JsonProperty("attackrange")]
    public int Attackrange { get; set; }

    [JsonProperty("hpregen")]
    public double Hpregen { get; set; }

    [JsonProperty("hpregenperlevel")]
    public double Hpregenperlevel { get; set; }

    [JsonProperty("mpregen")]
    public double Mpregen { get; set; }

    [JsonProperty("mpregenperlevel")]
    public double Mpregenperlevel { get; set; }

    [JsonProperty("crit")]
    public int Crit { get; set; }

    [JsonProperty("critperlevel")]
    public int Critperlevel { get; set; }

    [JsonProperty("attackdamage")]
    public double Attackdamage { get; set; }

    [JsonProperty("attackdamageperlevel")]
    public double Attackdamageperlevel { get; set; }

    [JsonProperty("attackspeedperlevel")]
    public double Attackspeedperlevel { get; set; }

    [JsonProperty("attackspeed")]
    public double Attackspeed { get; set; }
}