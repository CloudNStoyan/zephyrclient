using Newtonsoft.Json;

namespace Zephyr.Static.Champion;
public class ChampionFullImage
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

public class ChampionFullInfo
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

public class ChampionFullLeveltip
{
    [JsonProperty("label")]
    public List<string> Label { get; set; }

    [JsonProperty("effect")]
    public List<string> Effect { get; set; }
}

public class ChampionFullPassive
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("image")]
    public ChampionFullImage Image { get; set; }
}

public class ChampionFull
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("image")]
    public ChampionFullImage Image { get; set; }

    [JsonProperty("skins")]
    public List<Skin> Skins { get; set; }

    [JsonProperty("lore")]
    public string Lore { get; set; }

    [JsonProperty("blurb")]
    public string Blurb { get; set; }

    [JsonProperty("allytips")]
    public List<string> Allytips { get; set; }

    [JsonProperty("enemytips")]
    public List<string> Enemytips { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }

    [JsonProperty("partype")]
    public string Partype { get; set; }

    [JsonProperty("info")]
    public ChampionFullInfo Info { get; set; }

    [JsonProperty("stats")]
    public Stats Stats { get; set; }

    [JsonProperty("spells")]
    public List<Spell> Spells { get; set; }

    [JsonProperty("passive")]
    public ChampionFullPassive Passive { get; set; }

    [JsonProperty("recommended")]
    public List<object> Recommended { get; set; }
}

public class Skin
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("num")]
    public int Num { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("chromas")]
    public bool Chromas { get; set; }
}

public class Spell
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("tooltip")]
    public string Tooltip { get; set; }

    [JsonProperty("leveltip")]
    public ChampionFullLeveltip Leveltip { get; set; }

    [JsonProperty("maxrank")]
    public int Maxrank { get; set; }

    [JsonProperty("cooldown")]
    public List<double> Cooldown { get; set; }

    [JsonProperty("cooldownBurn")]
    public string CooldownBurn { get; set; }

    [JsonProperty("cost")]
    public List<int> Cost { get; set; }

    [JsonProperty("costBurn")]
    public string CostBurn { get; set; }

    [JsonProperty("datavalues")]
    public object Datavalues { get; set; }

    [JsonProperty("effect")]
    public List<List<double>> Effect { get; set; }

    [JsonProperty("effectBurn")]
    public List<string> EffectBurn { get; set; }

    [JsonProperty("vars")]
    public List<object> Vars { get; set; }

    [JsonProperty("costType")]
    public string CostType { get; set; }

    [JsonProperty("maxammo")]
    public string Maxammo { get; set; }

    [JsonProperty("range")]
    public List<int> Range { get; set; }

    [JsonProperty("rangeBurn")]
    public string RangeBurn { get; set; }

    [JsonProperty("image")]
    public ChampionFullImage Image { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }
}

public class Stats
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