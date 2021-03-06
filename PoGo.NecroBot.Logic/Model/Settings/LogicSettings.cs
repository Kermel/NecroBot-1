#region using directives

using System;
using System.Collections.Generic;
using System.Linq;
using PoGo.NecroBot.Logic.Interfaces.Configuration;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;

#endregion

namespace PoGo.NecroBot.Logic.Model.Settings
{
    public class LogicSettings : ILogicSettings
    {
        private readonly GlobalSettings _settings;

        public LogicSettings(GlobalSettings settings)
        {
            _settings = settings;
        }

        public string ProfilePath => _settings.ProfilePath;
        public string ProfileConfigPath => _settings.ProfileConfigPath;
        public string GeneralConfigPath => _settings.GeneralConfigPath;
        public int SchemaVersion => _settings.UpdateConfig.SchemaVersion;
        public bool CheckForUpdates => _settings.UpdateConfig.CheckForUpdates;
        public bool AutoUpdate => _settings.UpdateConfig.AutoUpdate;
        public bool UseWebsocket => _settings.WebsocketsConfig.UseWebsocket;
        public bool CatchPokemon => _settings.PokemonConfig.CatchPokemon;
        public int OutOfBallCatchBlockTime => _settings.PokemonConfig.OutOfBallCatchBlockTime;
        public int PokeballToKeepForSnipe => _settings.PokemonConfig.PokeballToKeepForSnipe;
        public int PokeballsToKeepForSnipe => _settings.PokemonConfig.PokeballToKeepForSnipe;

        public int CatchPokemonLimit => _settings.PokemonConfig.CatchPokemonLimit;
        public int CatchPokemonLimitMinutes => _settings.PokemonConfig.CatchPokemonLimitMinutes;
        public int PokeStopLimit => _settings.PokeStopConfig.PokeStopLimit;
        public int PokeStopLimitMinutes => _settings.PokeStopConfig.PokeStopLimitMinutes;
        public int SnipeCountLimit => _settings.SnipeConfig.SnipeCountLimit;
        public int SnipeRestSeconds => _settings.SnipeConfig.SnipeRestSeconds;
        public bool TransferWeakPokemon => _settings.PokemonConfig.TransferWeakPokemon;
        public bool DisableHumanWalking => _settings.LocationConfig.DisableHumanWalking;
        public int MaxBerriesToUsePerPokemon => _settings.PokemonConfig.MaxBerriesToUsePerPokemon;
        public float KeepMinIvPercentage => _settings.PokemonConfig.KeepMinIvPercentage;
        public string KeepMinOperator => _settings.PokemonConfig.KeepMinOperator;
        public int KeepMinCp => _settings.PokemonConfig.KeepMinCp;
        public int KeepMinLvl => _settings.PokemonConfig.KeepMinLvl;
        public bool UseKeepMinLvl => _settings.PokemonConfig.UseKeepMinLvl;
        public bool AutomaticallyLevelUpPokemon => _settings.PokemonConfig.AutomaticallyLevelUpPokemon;
        public bool OnlyUpgradeFavorites => _settings.PokemonConfig.OnlyUpgradeFavorites;
        public bool UseLevelUpList => _settings.PokemonConfig.UseLevelUpList;
        public int AmountOfTimesToUpgradeLoop => _settings.PokemonConfig.AmountOfTimesToUpgradeLoop;
        public string LevelUpByCPorIv => _settings.PokemonConfig.LevelUpByCPorIv;
        public int GetMinStarDustForLevelUp => _settings.PokemonConfig.GetMinStarDustForLevelUp;
        public bool UseLuckyEggConstantly => _settings.PokemonConfig.UseLuckyEggConstantly;
        public bool UseIncenseConstantly => _settings.PokemonConfig.UseIncenseConstantly;
        public float UseBerriesMinCp => _settings.PokemonConfig.UseBerriesMinCp;
        public float UseBerriesMinIv => _settings.PokemonConfig.UseBerriesMinIv;
        public double UseBerriesBelowCatchProbability => _settings.PokemonConfig.UseBerriesBelowCatchProbability;
        public string UseBerriesOperator => _settings.PokemonConfig.UseBerriesOperator;
        public float UpgradePokemonIvMinimum => _settings.PokemonConfig.UpgradePokemonIvMinimum;
        public float UpgradePokemonCpMinimum => _settings.PokemonConfig.UpgradePokemonCpMinimum;
        public string UpgradePokemonMinimumStatsOperator => _settings.PokemonConfig.UpgradePokemonMinimumStatsOperator;
        public double WalkingSpeedInKilometerPerHour => _settings.LocationConfig.WalkingSpeedInKilometerPerHour;
        public bool UseWalkingSpeedVariant => _settings.LocationConfig.UseWalkingSpeedVariant;
        public double WalkingSpeedVariant => _settings.LocationConfig.WalkingSpeedVariant;
        public bool ShowVariantWalking => _settings.LocationConfig.ShowVariantWalking;
        public bool FastSoftBanBypass => _settings.SoftBanConfig.FastSoftBanBypass;
        public int ByPassSpinCount  =>  _settings.SoftBanConfig.ByPassSpinCount;
        public bool EvolveAllPokemonWithEnoughCandy => _settings.PokemonConfig.EvolveAllPokemonWithEnoughCandy;
        public bool KeepPokemonsThatCanEvolve => _settings.PokemonConfig.KeepPokemonsThatCanEvolve;
        public bool TransferDuplicatePokemon => _settings.PokemonConfig.TransferDuplicatePokemon;
        public bool TransferDuplicatePokemonOnCapture => _settings.PokemonConfig.TransferDuplicatePokemonOnCapture;
        public bool UseBulkTransferPokemon => _settings.PokemonConfig.UseBulkTransferPokemon;

        public int BulkTransferSize => _settings.PokemonConfig.BulkTransferSize;
        public int BulkTransferStogareBuffer => _settings.PokemonConfig.BulkTransferStogareBuffer;

        public bool UseEggIncubators => _settings.PokemonConfig.UseEggIncubators;
        public bool UseLimitedEggIncubators => _settings.PokemonConfig.UseLimitedEggIncubators;
        public int UseGreatBallAboveCp => _settings.PokemonConfig.UseGreatBallAboveCp;
        public int UseUltraBallAboveCp => _settings.PokemonConfig.UseUltraBallAboveCp;
        public int UseMasterBallAboveCp => _settings.PokemonConfig.UseMasterBallAboveCp;
        public double UseGreatBallAboveIv => _settings.PokemonConfig.UseGreatBallAboveIv;
        public double UseUltraBallAboveIv => _settings.PokemonConfig.UseUltraBallAboveIv;
        public double UseMasterBallBelowCatchProbability => _settings.PokemonConfig.UseMasterBallBelowCatchProbability;
        public double UseUltraBallBelowCatchProbability => _settings.PokemonConfig.UseUltraBallBelowCatchProbability;
        public double UseGreatBallBelowCatchProbability => _settings.PokemonConfig.UseGreatBallBelowCatchProbability;
        public bool EnableHumanizedThrows => _settings.CustomCatchConfig.EnableHumanizedThrows;
        public bool EnableMissedThrows => _settings.CustomCatchConfig.EnableMissedThrows;
        public int ThrowMissPercentage => _settings.CustomCatchConfig.ThrowMissPercentage;
        public int NiceThrowChance => _settings.CustomCatchConfig.NiceThrowChance;
        public int GreatThrowChance => _settings.CustomCatchConfig.GreatThrowChance;
        public int ExcellentThrowChance => _settings.CustomCatchConfig.ExcellentThrowChance;
        public int CurveThrowChance => _settings.CustomCatchConfig.CurveThrowChance;
        public double ForceGreatThrowOverIv => _settings.CustomCatchConfig.ForceGreatThrowOverIv;
        public double ForceExcellentThrowOverIv => _settings.CustomCatchConfig.ForceExcellentThrowOverIv;
        public int ForceGreatThrowOverCp => _settings.CustomCatchConfig.ForceGreatThrowOverCp;
        public int ForceExcellentThrowOverCp => _settings.CustomCatchConfig.ForceExcellentThrowOverCp;
        public int DelayBetweenPokemonUpgrade => _settings.PokemonConfig.DelayBetweenPokemonUpgrade;
        public int DelayBetweenPokemonCatch => _settings.PokemonConfig.DelayBetweenPokemonCatch;

        public int DelayBetweenPlayerActions => _settings.PlayerConfig.DelayBetweenPlayerActions;
        public int EvolveActionDelay => _settings.PlayerConfig.EvolveActionDelay;
        public int TransferActionDelay => _settings.PlayerConfig.TransferActionDelay;
        public int RecycleActionDelay => _settings.PlayerConfig.RecycleActionDelay;
        public int RenamePokemonActionDelay => _settings.PlayerConfig.RenamePokemonActionDelay;
        public bool UseNearActionRandom => _settings.PlayerConfig.UseNearActionRandom;
        public bool UsePokemonToNotCatchFilter => _settings.PokemonConfig.UsePokemonToNotCatchFilter;
        public bool UsePokemonSniperFilterOnly => _settings.PokemonConfig.UsePokemonSniperFilterOnly;
        public int KeepMinDuplicatePokemon => _settings.PokemonConfig.KeepMinDuplicatePokemon;
        public bool PrioritizeIvOverCp => _settings.PokemonConfig.PrioritizeIvOverCp;
        public int MaxTravelDistanceInMeters => _settings.LocationConfig.MaxTravelDistanceInMeters;
        public string GpxFile => _settings.GPXConfig.GpxFile;
        public bool UseGpxPathing => _settings.GPXConfig.UseGpxPathing;
        public bool UseLuckyEggsWhileEvolving => _settings.PokemonConfig.UseLuckyEggsWhileEvolving;
        public int UseLuckyEggsMinPokemonAmount => _settings.PokemonConfig.UseLuckyEggsMinPokemonAmount;
        public bool EvolveAllPokemonAboveIv => _settings.PokemonConfig.EvolveAllPokemonAboveIv;
        public float EvolveAboveIvValue => _settings.PokemonConfig.EvolveAboveIvValue;
        public bool RenamePokemon => _settings.PokemonConfig.RenamePokemon;
        public bool RenameOnlyAboveIv => _settings.PokemonConfig.RenameOnlyAboveIv;
        public float FavoriteMinIvPercentage => _settings.PokemonConfig.FavoriteMinIvPercentage;
        public bool AutoFavoritePokemon => _settings.PokemonConfig.AutoFavoritePokemon;
        public string RenameTemplate => _settings.PokemonConfig.RenameTemplate;
        public int AmountOfPokemonToDisplayOnStart => _settings.ConsoleConfig.AmountOfPokemonToDisplayOnStart;
        public bool DumpPokemonStats => _settings.PokemonConfig.DumpPokemonStats;
        public string TranslationLanguageCode => _settings.ConsoleConfig.TranslationLanguageCode;
        public bool DetailedCountsBeforeRecycling => _settings.ConsoleConfig.DetailedCountsBeforeRecycling;
        public bool VerboseRecycling => _settings.RecycleConfig.VerboseRecycling;
        public double RecycleInventoryAtUsagePercentage => _settings.RecycleConfig.RecycleInventoryAtUsagePercentage;
        public double EvolveKeptPokemonsAtStorageUsagePercentage => _settings.PokemonConfig.EvolveKeptPokemonsAtStorageUsagePercentage;
        public int EvolveKeptPokemonIfBagHasOverThisManyPokemon => _settings.PokemonConfig.EvolveKeptPokemonIfBagHasOverThisManyPokemon;
        public ICollection<KeyValuePair<ItemId, int>> ItemRecycleFilter => _settings.ItemRecycleFilter.Select(itemRecycleFilter => new KeyValuePair<ItemId, int>(itemRecycleFilter.Key, itemRecycleFilter.Value)).ToList();
        public ICollection<PokemonId> PokemonsToEvolve => _settings.PokemonsToEvolve;
        public ICollection<PokemonId> PokemonsToLevelUp => _settings.PokemonsToLevelUp;
        public ICollection<PokemonId> PokemonsNotToTransfer => _settings.PokemonsNotToTransfer;
        public ICollection<PokemonId> PokemonsNotToCatch => _settings.PokemonsToIgnore;

        public ICollection<PokemonId> PokemonToUseMasterball => _settings.PokemonToUseMasterball;
        public Dictionary<PokemonId, TransferFilter> PokemonsTransferFilter => _settings.PokemonsTransferFilter;
        public Dictionary<PokemonId, UpgradeFilter> PokemonUpgradeFilters => _settings.PokemonUpgradeFilters;
        public Dictionary<PokemonId, SnipeFilter> PokemonSnipeFilters => _settings.SnipePokemonFilter;

        public bool StartupWelcomeDelay => _settings.ConsoleConfig.StartupWelcomeDelay;
        public bool UseGoogleWalk => _settings.GoogleWalkConfig.UseGoogleWalk;
        public double DefaultStepLength => _settings.GoogleWalkConfig.DefaultStepLength;
        public bool UseGoogleWalkCache => _settings.GoogleWalkConfig.Cache;
        public string GoogleApiKey => _settings.GoogleWalkConfig.GoogleAPIKey;
        public string GoogleHeuristic => _settings.GoogleWalkConfig.GoogleHeuristic;
        public string GoogleElevationApiKey => _settings.GoogleWalkConfig.GoogleElevationAPIKey;

        public bool UseYoursWalk => _settings.YoursWalkConfig.UseYoursWalk;
        public string YoursWalkHeuristic => _settings.YoursWalkConfig.YoursWalkHeuristic;

        public bool UseMapzenWalk => _settings.MapzenWalkConfig.UseMapzenWalk;
        public string MapzenTurnByTurnApiKey => _settings.MapzenWalkConfig.MapzenTurnByTurnApiKey;
        public string MapzenWalkHeuristic => _settings.MapzenWalkConfig.MapzenWalkHeuristic;
        public string MapzenElevationApiKey => _settings.MapzenWalkConfig.MapzenElevationApiKey;

        public bool SnipeAtPokestops => _settings.SnipeConfig.SnipeAtPokestops;
        public bool ActivateMSniper => _settings.SnipeConfig.ActivateMSniper;
        public bool UseTelegramAPI => _settings.TelegramConfig.UseTelegramAPI;
        public string TelegramAPIKey => _settings.TelegramConfig.TelegramAPIKey;
        public string TelegramPassword => _settings.TelegramConfig.TelegramPassword;
        public int MinPokeballsToSnipe => _settings.SnipeConfig.MinPokeballsToSnipe;
        public int MinPokeballsWhileSnipe => _settings.SnipeConfig.MinPokeballsWhileSnipe;
        public int MaxPokeballsPerPokemon => _settings.PokemonConfig.MaxPokeballsPerPokemon;
        public bool RandomlyPauseAtStops => _settings.LocationConfig.RandomlyPauseAtStops;
        public SnipeSettings PokemonToSnipe => _settings.PokemonToSnipe;
        public string SnipeLocationServer => _settings.SnipeConfig.SnipeLocationServer;
        public int SnipeLocationServerPort => _settings.SnipeConfig.SnipeLocationServerPort;
        public bool GetSniperInfoFromPokezz => _settings.SnipeConfig.GetSniperInfoFromPokezz;
        public bool GetOnlyVerifiedSniperInfoFromPokezz => _settings.SnipeConfig.GetOnlyVerifiedSniperInfoFromPokezz;
        public bool GetSniperInfoFromPokeSnipers => _settings.SnipeConfig.GetSniperInfoFromPokeSnipers;
        public bool GetSniperInfoFromPokeWatchers => _settings.SnipeConfig.GetSniperInfoFromPokeWatchers;
        public bool GetSniperInfoFromSkiplagged => _settings.SnipeConfig.GetSniperInfoFromSkiplagged;
        public bool UseSnipeLocationServer => _settings.SnipeConfig.UseSnipeLocationServer;
        public bool UseTransferIvForSnipe => _settings.SnipeConfig.UseTransferIvForSnipe;
        public bool SnipeIgnoreUnknownIv => _settings.SnipeConfig.SnipeIgnoreUnknownIv;
        public int MinDelayBetweenSnipes => _settings.SnipeConfig.MinDelayBetweenSnipes;
        public double SnipingScanOffset => _settings.SnipeConfig.SnipingScanOffset;
        public bool SnipePokemonNotInPokedex => _settings.SnipeConfig.SnipePokemonNotInPokedex;
        public bool RandomizeRecycle => _settings.RecycleConfig.RandomizeRecycle;
        public int RandomRecycleValue => _settings.RecycleConfig.RandomRecycleValue;
        public int MaxPokeballsToKeep => _settings.RecycleConfig.MaxPokeballsToKeep;
        public int TotalAmountOfPokeballsToKeep => _settings.RecycleConfig.TotalAmountOfPokeballsToKeep;
        public int TotalAmountOfPotionsToKeep => _settings.RecycleConfig.TotalAmountOfPotionsToKeep;
        public int TotalAmountOfRevivesToKeep => _settings.RecycleConfig.TotalAmountOfRevivesToKeep;
        public int TotalAmountOfBerriesToKeep => _settings.RecycleConfig.TotalAmountOfBerriesToKeep;
        public bool UseSnipeLimit => _settings.SnipeConfig.UseSnipeLimit;
        public bool UsePokeStopLimit => _settings.PokeStopConfig.UsePokeStopLimit;
        public bool UseCatchLimit => _settings.PokemonConfig.UseCatchLimit;
        public int ResumeTrack => _settings.LocationConfig.ResumeTrack;
        public int ResumeTrackSeg => _settings.LocationConfig.ResumeTrackSeg;
        public int ResumeTrackPt => _settings.LocationConfig.ResumeTrackPt;
        public bool EnableHumanWalkingSnipe => _settings.HumanWalkSnipeConfig.Enable;
        public bool HumanWalkingSnipeDisplayList => _settings.HumanWalkSnipeConfig.DisplayPokemonList;
        public double HumanWalkingSnipeMaxDistance => _settings.HumanWalkSnipeConfig.MaxDistance;
        public double HumanWalkingSnipeMaxEstimateTime => _settings.HumanWalkSnipeConfig.MaxEstimateTime;
        public bool HumanWalkingSnipeTryCatchEmAll => _settings.HumanWalkSnipeConfig.TryCatchEmAll;
        public int HumanWalkingSnipeCatchEmAllMinBalls => _settings.HumanWalkSnipeConfig.CatchEmAllMinBalls;
        public bool HumanWalkingSnipeCatchPokemonWhileWalking => _settings.HumanWalkSnipeConfig.CatchPokemonWhileWalking;
        public bool HumanWalkingSnipeSpinWhileWalking => _settings.HumanWalkSnipeConfig.SpinWhileWalking;
        public bool HumanWalkingSnipeAlwaysWalkBack => _settings.HumanWalkSnipeConfig.AlwaysWalkback;
        public double HumanWalkingSnipeWalkbackDistanceLimit => _settings.HumanWalkSnipeConfig.WalkbackDistanceLimit;
        public double HumanWalkingSnipeSnipingScanOffset => _settings.HumanWalkSnipeConfig.SnipingScanOffset;
        public bool HumanWalkingSnipeIncludeDefaultLocation => _settings.HumanWalkSnipeConfig.IncludeDefaultLocation;
        public bool HumanWalkingSnipeUseSnipePokemonList => _settings.HumanWalkSnipeConfig.UseSnipePokemonList;
        public Dictionary<PokemonId, HumanWalkSnipeFilter> HumanWalkSnipeFilters => _settings.HumanWalkSnipeFilters;
        public bool HumanWalkingSnipeAllowSpeedUp => _settings.HumanWalkSnipeConfig.AllowSpeedUp;
        public double HumanWalkingSnipeMaxSpeedUpSpeed => _settings.HumanWalkSnipeConfig.MaxSpeedUpSpeed;
        public int HumanWalkingSnipeDelayTimeAtDestination => _settings.HumanWalkSnipeConfig.DelayTimeAtDestination;
        public bool HumanWalkingSnipeUsePokeRadar => _settings.HumanWalkSnipeConfig.UsePokeRadar;
        public bool HumanWalkingSnipeUseSkiplagged => _settings.HumanWalkSnipeConfig.UseSkiplagged;
        public bool HumanWalkingSnipeUsePokecrew => _settings.HumanWalkSnipeConfig.UsePokecrew;
        public bool HumanWalkingSnipeUsePokesnipers => _settings.HumanWalkSnipeConfig.UsePokesnipers;
        public bool HumanWalkingSnipeUsePokeZZ => _settings.HumanWalkSnipeConfig.UsePokeZZ;
        public bool HumanWalkingSnipeUsePokeWatcher => _settings.HumanWalkSnipeConfig.UsePokeWatcher;
        public bool HumanWalkingSnipeUseFastPokemap => _settings.HumanWalkSnipeConfig.UseFastPokemap;
        public bool HumanWalkingSnipeUsePogoLocationFeeder => _settings.HumanWalkSnipeConfig.UsePogoLocationFeeder;
        public bool HumanWalkingSnipeAllowTransferWhileWalking => _settings.HumanWalkSnipeConfig.AllowTransferWhileWalking;
        public int GymCollectRewardAfter => _settings.GymConfig.CollectCoinAfterDeployed;
        public bool GymAllowed => _settings.GymConfig.Enable;
        public bool GymPrioritizeOverPokestop => _settings.GymConfig.PrioritizeGymOverPokestop;
        public TeamColor GymDefaultTeam =>(TeamColor)Enum.Parse(typeof(TeamColor), _settings.GymConfig.DefaultTeam);

        public double GymMaxDistance => _settings.GymConfig.MaxDistance;
        public int GymVisitTimeout => _settings.GymConfig.VisitTimeout;
        public int GymMaxCPToDeploy => _settings.GymConfig.MaxCPToDeploy;
        public int GymMaxLevelToDeploy => _settings.GymConfig.MaxLevelToDeploy;

        public bool GymUseRandomPokemon => _settings.GymConfig.UseRandomPokemon;

        public int GymNumberOfTopPokemonToBeExcluded => _settings.GymConfig.NumberOfTopPokemonToBeExcluded;

        public bool DataSharingEnable => _settings.DataSharingConfig.EnableSyncData;
        public string DataSharingIdentifiation => _settings.DataSharingConfig.DataServiceIdentification;
        public bool AllowAutoSnipe => _settings.DataSharingConfig.AutoSnipe;

        public string DataSharingDataUrl => _settings.DataSharingConfig.DataRecieverURL;

        public bool UseTransferFilterToCatch => _settings.CustomCatchConfig.UseTransferFilterToCatch;

        public MultipleBotConfig MultipleBotConfig => _settings.MultipleBotConfig;
        public List<AuthConfig> Bots => _settings.Auth.Bots;
        public bool AllowMultipleBot => _settings.Auth.AllowMultipleBot;
        public int MinIVForAutoSnipe => _settings.SnipeConfig.MinIVForAutoSnipe;
        public bool AutosnipeVerifiedOnly => _settings.SnipeConfig.AutosnipeVerifiedOnly;
        public Dictionary<PokemonId, BotSwitchPokemonFilter> BotSwitchPokemonFilters => _settings.BotSwitchPokemonFilters;

        public NotificationConfig NotificationConfig => _settings.NotificationConfig;

        public CaptchaConfig CaptchaConfig => _settings.CaptchaConfig;
    }
}
