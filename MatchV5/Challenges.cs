using Newtonsoft.Json;

namespace Zephyr.MatchV5
{
    public class Challenges
    {
        [JsonProperty("12AssistStreakCount")]
        public int _12AssistStreakCount { get; set; }

        [JsonProperty("abilityUses")]
        public int AbilityUses { get; set; }

        [JsonProperty("acesBefore15Minutes")]
        public int AcesBefore15Minutes { get; set; }

        [JsonProperty("alliedJungleMonsterKills")]
        public double AlliedJungleMonsterKills { get; set; }

        [JsonProperty("baronTakedowns")]
        public int BaronTakedowns { get; set; }

        [JsonProperty("blastConeOppositeOpponentCount")]
        public int BlastConeOppositeOpponentCount { get; set; }

        [JsonProperty("bountyGold")]
        public int BountyGold { get; set; }

        [JsonProperty("buffsStolen")]
        public int BuffsStolen { get; set; }

        [JsonProperty("completeSupportQuestInTime")]
        public int CompleteSupportQuestInTime { get; set; }

        [JsonProperty("controlWardsPlaced")]
        public int ControlWardsPlaced { get; set; }

        [JsonProperty("damagePerMinute")]
        public double DamagePerMinute { get; set; }

        [JsonProperty("damageTakenOnTeamPercentage")]
        public double DamageTakenOnTeamPercentage { get; set; }

        [JsonProperty("dancedWithRiftHerald")]
        public int DancedWithRiftHerald { get; set; }

        [JsonProperty("deathsByEnemyChamps")]
        public int DeathsByEnemyChamps { get; set; }

        [JsonProperty("dodgeSkillShotsSmallWindow")]
        public int DodgeSkillShotsSmallWindow { get; set; }

        [JsonProperty("doubleAces")]
        public int DoubleAces { get; set; }

        [JsonProperty("dragonTakedowns")]
        public int DragonTakedowns { get; set; }

        [JsonProperty("earlyLaningPhaseGoldExpAdvantage")]
        public int EarlyLaningPhaseGoldExpAdvantage { get; set; }

        [JsonProperty("effectiveHealAndShielding")]
        public double EffectiveHealAndShielding { get; set; }

        [JsonProperty("elderDragonKillsWithOpposingSoul")]
        public int ElderDragonKillsWithOpposingSoul { get; set; }

        [JsonProperty("elderDragonMultikills")]
        public int ElderDragonMultikills { get; set; }

        [JsonProperty("enemyChampionImmobilizations")]
        public int EnemyChampionImmobilizations { get; set; }

        [JsonProperty("enemyJungleMonsterKills")]
        public double EnemyJungleMonsterKills { get; set; }

        [JsonProperty("epicMonsterKillsNearEnemyJungler")]
        public int EpicMonsterKillsNearEnemyJungler { get; set; }

        [JsonProperty("epicMonsterKillsWithin30SecondsOfSpawn")]
        public int EpicMonsterKillsWithin30SecondsOfSpawn { get; set; }

        [JsonProperty("epicMonsterSteals")]
        public int EpicMonsterSteals { get; set; }

        [JsonProperty("epicMonsterStolenWithoutSmite")]
        public int EpicMonsterStolenWithoutSmite { get; set; }

        [JsonProperty("flawlessAces")]
        public int FlawlessAces { get; set; }

        [JsonProperty("fullTeamTakedown")]
        public int FullTeamTakedown { get; set; }

        [JsonProperty("gameLength")]
        public double GameLength { get; set; }

        [JsonProperty("getTakedownsInAllLanesEarlyJungleAsLaner")]
        public int GetTakedownsInAllLanesEarlyJungleAsLaner { get; set; }

        [JsonProperty("goldPerMinute")]
        public double GoldPerMinute { get; set; }

        [JsonProperty("hadOpenNexus")]
        public int HadOpenNexus { get; set; }

        [JsonProperty("immobilizeAndKillWithAlly")]
        public int ImmobilizeAndKillWithAlly { get; set; }

        [JsonProperty("initialBuffCount")]
        public int InitialBuffCount { get; set; }

        [JsonProperty("initialCrabCount")]
        public int InitialCrabCount { get; set; }

        [JsonProperty("jungleCsBefore10Minutes")]
        public double JungleCsBefore10Minutes { get; set; }

        [JsonProperty("junglerTakedownsNearDamagedEpicMonster")]
        public int JunglerTakedownsNearDamagedEpicMonster { get; set; }

        [JsonProperty("kTurretsDestroyedBeforePlatesFall")]
        public int KTurretsDestroyedBeforePlatesFall { get; set; }

        [JsonProperty("kda")]
        public double Kda { get; set; }

        [JsonProperty("killAfterHiddenWithAlly")]
        public int KillAfterHiddenWithAlly { get; set; }

        [JsonProperty("killParticipation")]
        public double KillParticipation { get; set; }

        [JsonProperty("killedChampTookFullTeamDamageSurvived")]
        public int KilledChampTookFullTeamDamageSurvived { get; set; }

        [JsonProperty("killsNearEnemyTurret")]
        public int KillsNearEnemyTurret { get; set; }

        [JsonProperty("killsOnOtherLanesEarlyJungleAsLaner")]
        public int KillsOnOtherLanesEarlyJungleAsLaner { get; set; }

        [JsonProperty("killsOnRecentlyHealedByAramPack")]
        public int KillsOnRecentlyHealedByAramPack { get; set; }

        [JsonProperty("killsUnderOwnTurret")]
        public int KillsUnderOwnTurret { get; set; }

        [JsonProperty("killsWithHelpFromEpicMonster")]
        public int KillsWithHelpFromEpicMonster { get; set; }

        [JsonProperty("knockEnemyIntoTeamAndKill")]
        public int KnockEnemyIntoTeamAndKill { get; set; }

        [JsonProperty("landSkillShotsEarlyGame")]
        public int LandSkillShotsEarlyGame { get; set; }

        [JsonProperty("laneMinionsFirst10Minutes")]
        public int LaneMinionsFirst10Minutes { get; set; }

        [JsonProperty("laningPhaseGoldExpAdvantage")]
        public int LaningPhaseGoldExpAdvantage { get; set; }

        [JsonProperty("legendaryCount")]
        public int LegendaryCount { get; set; }

        [JsonProperty("lostAnInhibitor")]
        public int LostAnInhibitor { get; set; }

        [JsonProperty("maxCsAdvantageOnLaneOpponent")]
        public double MaxCsAdvantageOnLaneOpponent { get; set; }

        [JsonProperty("maxKillDeficit")]
        public int MaxKillDeficit { get; set; }

        [JsonProperty("maxLevelLeadLaneOpponent")]
        public int MaxLevelLeadLaneOpponent { get; set; }

        [JsonProperty("moreEnemyJungleThanOpponent")]
        public double MoreEnemyJungleThanOpponent { get; set; }

        [JsonProperty("multiKillOneSpell")]
        public int MultiKillOneSpell { get; set; }

        [JsonProperty("multiTurretRiftHeraldCount")]
        public int MultiTurretRiftHeraldCount { get; set; }

        [JsonProperty("multikills")]
        public int Multikills { get; set; }

        [JsonProperty("multikillsAfterAggressiveFlash")]
        public int MultikillsAfterAggressiveFlash { get; set; }

        [JsonProperty("mythicItemUsed")]
        public int MythicItemUsed { get; set; }

        [JsonProperty("outerTurretExecutesBefore10Minutes")]
        public int OuterTurretExecutesBefore10Minutes { get; set; }

        [JsonProperty("outnumberedKills")]
        public int OutnumberedKills { get; set; }

        [JsonProperty("outnumberedNexusKill")]
        public int OutnumberedNexusKill { get; set; }

        [JsonProperty("perfectDragonSoulsTaken")]
        public int PerfectDragonSoulsTaken { get; set; }

        [JsonProperty("perfectGame")]
        public int PerfectGame { get; set; }

        [JsonProperty("pickKillWithAlly")]
        public int PickKillWithAlly { get; set; }

        [JsonProperty("playedChampSelectPosition")]
        public int PlayedChampSelectPosition { get; set; }

        [JsonProperty("poroExplosions")]
        public int PoroExplosions { get; set; }

        [JsonProperty("quickCleanse")]
        public int QuickCleanse { get; set; }

        [JsonProperty("quickFirstTurret")]
        public int QuickFirstTurret { get; set; }

        [JsonProperty("quickSoloKills")]
        public int QuickSoloKills { get; set; }

        [JsonProperty("riftHeraldTakedowns")]
        public int RiftHeraldTakedowns { get; set; }

        [JsonProperty("saveAllyFromDeath")]
        public int SaveAllyFromDeath { get; set; }

        [JsonProperty("scuttleCrabKills")]
        public int ScuttleCrabKills { get; set; }

        [JsonProperty("skillshotsDodged")]
        public int SkillshotsDodged { get; set; }

        [JsonProperty("skillshotsHit")]
        public int SkillshotsHit { get; set; }

        [JsonProperty("snowballsHit")]
        public int SnowballsHit { get; set; }

        [JsonProperty("soloBaronKills")]
        public int SoloBaronKills { get; set; }

        [JsonProperty("soloKills")]
        public int SoloKills { get; set; }

        [JsonProperty("stealthWardsPlaced")]
        public int StealthWardsPlaced { get; set; }

        [JsonProperty("survivedSingleDigitHpCount")]
        public int SurvivedSingleDigitHpCount { get; set; }

        [JsonProperty("survivedThreeImmobilizesInFight")]
        public int SurvivedThreeImmobilizesInFight { get; set; }

        [JsonProperty("takedownOnFirstTurret")]
        public int TakedownOnFirstTurret { get; set; }

        [JsonProperty("takedowns")]
        public int Takedowns { get; set; }

        [JsonProperty("takedownsAfterGainingLevelAdvantage")]
        public int TakedownsAfterGainingLevelAdvantage { get; set; }

        [JsonProperty("takedownsBeforeJungleMinionSpawn")]
        public int TakedownsBeforeJungleMinionSpawn { get; set; }

        [JsonProperty("takedownsFirstXMinutes")]
        public int TakedownsFirstXMinutes { get; set; }

        [JsonProperty("takedownsInAlcove")]
        public int TakedownsInAlcove { get; set; }

        [JsonProperty("takedownsInEnemyFountain")]
        public int TakedownsInEnemyFountain { get; set; }

        [JsonProperty("teamBaronKills")]
        public int TeamBaronKills { get; set; }

        [JsonProperty("teamDamagePercentage")]
        public double TeamDamagePercentage { get; set; }

        [JsonProperty("teamElderDragonKills")]
        public int TeamElderDragonKills { get; set; }

        [JsonProperty("teamRiftHeraldKills")]
        public int TeamRiftHeraldKills { get; set; }

        [JsonProperty("threeWardsOneSweeperCount")]
        public int ThreeWardsOneSweeperCount { get; set; }

        [JsonProperty("tookLargeDamageSurvived")]
        public int TookLargeDamageSurvived { get; set; }

        [JsonProperty("turretPlatesTaken")]
        public int TurretPlatesTaken { get; set; }

        [JsonProperty("turretTakedowns")]
        public int TurretTakedowns { get; set; }

        [JsonProperty("turretsTakenWithRiftHerald")]
        public int TurretsTakenWithRiftHerald { get; set; }

        [JsonProperty("twentyMinionsIn3SecondsCount")]
        public int TwentyMinionsIn3SecondsCount { get; set; }

        [JsonProperty("unseenRecalls")]
        public int UnseenRecalls { get; set; }

        [JsonProperty("visionScoreAdvantageLaneOpponent")]
        public double VisionScoreAdvantageLaneOpponent { get; set; }

        [JsonProperty("visionScorePerMinute")]
        public double VisionScorePerMinute { get; set; }

        [JsonProperty("wardTakedowns")]
        public int WardTakedowns { get; set; }

        [JsonProperty("wardTakedownsBefore20M")]
        public int WardTakedownsBefore20M { get; set; }

        [JsonProperty("wardsGuarded")]
        public int WardsGuarded { get; set; }

        [JsonProperty("junglerKillsEarlyJungle")]
        public int? JunglerKillsEarlyJungle { get; set; }

        [JsonProperty("killsOnLanersEarlyJungleAsJungler")]
        public int? KillsOnLanersEarlyJungleAsJungler { get; set; }

        [JsonProperty("controlWardTimeCoverageInRiverOrEnemyHalf")]
        public double? ControlWardTimeCoverageInRiverOrEnemyHalf { get; set; }

        [JsonProperty("highestWardKills")]
        public int? HighestWardKills { get; set; }

        [JsonProperty("baronBuffGoldAdvantageOverThreshold")]
        public int? BaronBuffGoldAdvantageOverThreshold { get; set; }

        [JsonProperty("earliestBaron")]
        public double? EarliestBaron { get; set; }

        [JsonProperty("earliestDragonTakedown")]
        public double? EarliestDragonTakedown { get; set; }

        [JsonProperty("firstTurretKilledTime")]
        public double? FirstTurretKilledTime { get; set; }

        [JsonProperty("soloTurretsLategame")]
        public int? SoloTurretsLategame { get; set; }

        [JsonProperty("thirdInhibitorDestroyedTime")]
        public double? ThirdInhibitorDestroyedTime { get; set; }

        [JsonProperty("highestCrowdControlScore")]
        public int? HighestCrowdControlScore { get; set; }

        [JsonProperty("teleportTakedowns")]
        public int? TeleportTakedowns { get; set; }

        [JsonProperty("highestChampionDamage")]
        public int? HighestChampionDamage { get; set; }
    }

}