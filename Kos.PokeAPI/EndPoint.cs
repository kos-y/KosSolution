using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.PokeAPI.Attribute;

namespace Kos.PokeAPI;

/// <summary>
/// エンド・ポイント
/// </summary>
public enum EndPoint
{
    /// <summary>
    /// 木の実
    /// </summary>
    [EndPoint(nameof(Berries), "berry")]
    Berries,

    /// <summary>
    /// 木の実 硬さ
    /// </summary>
    [EndPoint(nameof(BerryFirmnesses), "berry-firmness")]
    BerryFirmnesses,

    /// <summary>
    /// 木の実 味
    /// </summary>
    [EndPoint(nameof(BerryFlavors), "berry-flavor")]
    BerryFlavors,

    /// <summary>
    /// コンテスト タイプ
    /// </summary>
    [EndPoint(nameof(ContestTypes), "contest-type")]
    ContestTypes,

    /// <summary>
    /// コンテスト 効果
    /// </summary>
    [EndPoint(nameof(ContestEffects), "contest-effect")]
    ContestEffects,

    /// <summary>
    /// スーパーコンテスト 効果
    /// </summary>
    [EndPoint(nameof(SuperContestEffects), "super-contest-effect")]
    SuperContestEffects,

    /// <summary>
    /// エンカウント 方法
    /// </summary>
    [EndPoint(nameof(EncounterMethods), "encounter-method")]
    EncounterMethods,

    /// <summary>
    /// 遭遇 条件
    /// </summary>
    [EndPoint(nameof(EncounterConditions), "encounter-condition")]
    EncounterConditions,

    /// <summary>
    /// 遭遇 条件値
    /// </summary>
    [EndPoint(nameof(EncounterConditionValues), "encounter-condition-value")]
    EncounterConditionValues,

    /// <summary>
    /// 進化 チェーン
    /// </summary>
    [EndPoint(nameof(EvolutionChains), "evolution-chain")]
    EvolutionChains,

    /// <summary>
    /// 進化 トリガー
    /// </summary>
    [EndPoint(nameof(EvolutionTriggers), "evolution-trigger")]
    EvolutionTriggers,

    /// <summary>
    /// 世代
    /// </summary>
    [EndPoint(nameof(Generations), "generation")]
    Generations,

    /// <summary>
    /// ポケモン図鑑
    /// </summary>
    [EndPoint(nameof(Pokedexes), "pokedex")]
    Pokedexes,

    /// <summary>
    /// バージョン
    /// </summary>
    [EndPoint(nameof(Version), "version")]
    Version,

    /// <summary>
    /// バージョン グループ
    /// </summary>
    [EndPoint(nameof(VersionGroups), "version-group")]
    VersionGroups,

    /// <summary>
    /// アイテム
    /// </summary>
    [EndPoint(nameof(Item), "item")]
    Item,

    /// <summary>
    /// アイテム 属性
    /// </summary>
    [EndPoint(nameof(ItemAttributes), "item-attribute")]
    ItemAttributes,

    /// <summary>
    /// アイテム カテゴリ
    /// </summary>
    [EndPoint(nameof(ItemCategories), "item-category")]
    ItemCategories,

    /// <summary>
    /// アイテム なげつけるの効果
    /// </summary>
    [EndPoint(nameof(ItemFlingEffects), "item-fling-effect")]
    ItemFlingEffects,

    /// <summary>
    /// アイテム ポケット
    /// </summary>
    [EndPoint(nameof(ItemPockets), "item-pocket")]
    ItemPockets,

    /// <summary>
    /// 場所
    /// </summary>
    [EndPoint(nameof(Locations), "location")]
    Locations,

    /// <summary>
    /// ロケーションエリア
    /// </summary>
    [EndPoint(nameof(LocationAreas), "location-area")]
    LocationAreas,

    /// <summary>
    /// パルパーク エリア
    /// </summary>
    [EndPoint(nameof(PalParkAreas), "pal-park-area")]
    PalParkAreas,

    /// <summary>
    /// 地域
    /// </summary>
    [EndPoint(nameof(Regions), "region")]
    Regions,

    /// <summary>
    /// 技マシン
    /// </summary>
    [EndPoint(nameof(Machines), "machine")]
    Machines,

    /// <summary>
    /// 技
    /// </summary>
    [EndPoint(nameof(Moves), "move")]
    Moves,

    /// <summary>
    /// 技 状態異常
    /// </summary>
    [EndPoint(nameof(MoveAilments), "move-ailment")]
    MoveAilments,

    /// <summary>
    /// 技 戦闘スタイル
    /// </summary>
    [EndPoint(nameof(MoveBattleStyles), "move-battle-style")]
    MoveBattleStyles,

    /// <summary>
    /// 技 カテゴリ
    /// </summary>
    [EndPoint(nameof(MoveCategories), "move-category")]
    MoveCategories,

    /// <summary>
    /// 技 ダメージクラス
    /// </summary>
    [EndPoint(nameof(MoveDamageClasses), "move-damage-class")]
    MoveDamageClasses,

    /// <summary>
    /// 技 習得方法
    /// </summary>
    [EndPoint(nameof(MoveLearnMethods), "move-learn-method")]
    MoveLearnMethods,

    /// <summary>
    /// 技 ターゲット
    /// </summary>
    [EndPoint(nameof(MoveTargets), "move-target")]
    MoveTargets,

    /// <summary>
    /// 特性
    /// </summary>
    [EndPoint(nameof(Abilities), "ability")]
    Abilities,

    /// <summary>
    /// 特徴
    /// </summary>
    [EndPoint(nameof(Characteristics), "characteristic")]
    Characteristics,

    /// <summary>
    /// 卵グループ
    /// </summary>
    [EndPoint(nameof(EggGroups), "egg-group")]
    EggGroups,

    /// <summary>
    /// 性別
    /// </summary>
    [EndPoint(nameof(Genders), "gender")]
    Genders,

    /// <summary>
    /// 成長パターン
    /// </summary>
    [EndPoint(nameof(GrowthRates), "growth-rate")]
    GrowthRates,

    /// <summary>
    /// 性格
    /// </summary>
    [EndPoint(nameof(Natures), "nature")]
    Natures,

    /// <summary>
    /// ポケアスロン ステータス
    /// </summary>
    [EndPoint(nameof(PokeathlonStats), "pokeathlon-stat")]
    PokeathlonStats,

    /// <summary>
    /// ポケモン
    /// </summary>
    [EndPoint(nameof(Pokemon), "pokemon")]
    Pokemon,

    /// <summary>
    /// ポケモン 特定生息場所
    /// </summary>
    [EndPoint(nameof(PokemonLocationAreas), "pokemon", "encounters")]
    PokemonLocationAreas,

    /// <summary>
    /// ポケモン 色
    /// </summary>
    [EndPoint(nameof(PokemonColors), "pokemon-color")]
    PokemonColors,

    /// <summary>
    /// ポケモン フォーム
    /// </summary>
    [EndPoint(nameof(PokemonForms), "pokemon-form")]
    PokemonForms,

    /// <summary>
    /// ポケモン 生息環境
    /// </summary>
    [EndPoint(nameof(PokemonHabitats), "pokemon-habitat")]
    PokemonHabitats,

    /// <summary>
    /// ポケモン 形
    /// </summary>
    [EndPoint(nameof(PokemonShapes), "pokemon-shape")]
    PokemonShapes,

    /// <summary>
    /// ポケモン 種族
    /// </summary>
    [EndPoint(nameof(PokemonSpecies), "pokemon-species")]
    PokemonSpecies,

    /// <summary>
    /// ステータス
    /// </summary>
    [EndPoint(nameof(Stats), "stat")]
    Stats,

    /// <summary>
    /// タイプ
    /// </summary>
    [EndPoint(nameof(Types), "type")]
    Types,

    /// <summary>
    /// 言語
    /// </summary>
    [EndPoint(nameof(Languages), "language")]
    Languages,

}
