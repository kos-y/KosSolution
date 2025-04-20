using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.PokeAPI.Attribute;

namespace Kos.PokeAPI;

/// <summary>
/// リソースカテゴリ
/// </summary>
public enum ResourceCategory
{
    /// <summary>
    /// 木の実
    /// </summary>
    [ResourceCategory(
        nameof(Berries),
        EndPoint.Berries,
        EndPoint.BerryFirmnesses,
        EndPoint.BerryFlavors)]
    Berries,

    /// <summary>
    /// コンテスト
    /// </summary>
    [ResourceCategory(
        nameof(Contests),
        EndPoint.ContestTypes,
        EndPoint.ContestEffects,
        EndPoint.SuperContestEffects)]
    Contests,

    /// <summary>
    /// エンカウント
    /// </summary>
    [ResourceCategory(
        nameof(Encounters),
        EndPoint.EncounterMethods,
        EndPoint.EncounterConditions,
        EndPoint.EncounterConditionValues)]
    Encounters,

    /// <summary>
    /// 進化
    /// </summary>
    [ResourceCategory(
        nameof(Evolution),
        EndPoint.EvolutionChains,
        EndPoint.EvolutionTriggers)]
    Evolution,

    /// <summary>
    /// ゲーム
    /// </summary>
    [ResourceCategory(
        nameof(Games),
        EndPoint.Generations,
        EndPoint.Pokedexes,
        EndPoint.Version,
        EndPoint.VersionGroups)]
    Games,

    /// <summary>
    /// アイテム
    /// </summary>
    [ResourceCategory(
        nameof(Items),
        EndPoint.Item,
        EndPoint.ItemAttributes,
        EndPoint.ItemCategories,
        EndPoint.ItemFlingEffects,
        EndPoint.ItemPockets)]
    Items,

    /// <summary>
    /// 場所
    /// </summary>
    [ResourceCategory(
        nameof(Locations),
        EndPoint.Locations,
        EndPoint.LocationAreas,
        EndPoint.PalParkAreas,
        EndPoint.Regions)]
    Locations,

    /// <summary>
    /// 技マシン
    /// </summary>
    [ResourceCategory(
        nameof(Machines),
        EndPoint.Machines)]
    Machines,

    /// <summary>
    /// 技
    /// </summary>
    [ResourceCategory(
        nameof(Moves),
        EndPoint.Moves,
        EndPoint.MoveAilments,
        EndPoint.MoveBattleStyles,
        EndPoint.MoveCategories,
        EndPoint.MoveDamageClasses,
        EndPoint.MoveLearnMethods,
        EndPoint.MoveTargets)]
    Moves,

    /// <summary>
    /// ポケモン
    /// </summary>
    [ResourceCategory(
        nameof(Pokemon),
        EndPoint.Abilities,
        EndPoint.Characteristics,
        EndPoint.EggGroups,
        EndPoint.Genders,
        EndPoint.GrowthRates,
        EndPoint.Natures,
        EndPoint.PokeathlonStats,
        EndPoint.Pokemon,
        EndPoint.PokemonLocationAreas,
        EndPoint.PokemonColors,
        EndPoint.PokemonHabitats,
        EndPoint.PokemonShapes,
        EndPoint.PokemonSpecies,
        EndPoint.Stats,
        EndPoint.Types)]
    Pokemon,

    /// <summary>
    /// ユーティリティ
    /// </summary>
    [ResourceCategory(
        nameof(Utility),
        EndPoint.Languages)]
    Utility
}
