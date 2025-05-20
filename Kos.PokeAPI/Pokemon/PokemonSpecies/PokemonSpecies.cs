using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonSpecies;

/// <summary>
/// ポケモン種族
/// </summary>
public class PokemonSpecies
{
    #region ポケモン種族ID
    /// <summary>
    /// ポケモン種族ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("ポケモン種族")]
    [Description("ポケモン種族ID")]
    public int? Id { get; set; }
    #endregion

    #region ポケモン種族の名前
    /// <summary>
    /// ポケモン種族の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("ポケモン種族")]
    [Description("ポケモン種族の名前")]
    public string? Name { get; set; }
    #endregion

    #region 順番
    /// <summary>
    /// 順番
    /// </summary>
    [JsonPropertyName("order")]
    [DisplayName("order")]
    [Category("ポケモン種族")]
    [Description("順番")]
    public int? Order { get; set; }
    #endregion

    #region メスになる確率
    /// <summary>
    /// メスになる確率
    /// </summary>
    [JsonPropertyName("gender_rate")]
    [DisplayName("gender_rate")]
    [Category("ポケモン種族")]
    [Description("メスになる確率")]
    public int? GenderRate { get; set; }
    #endregion

    #region 捕獲率
    /// <summary>
    /// 捕獲率
    /// </summary>
    [JsonPropertyName("capture_rate")]
    [DisplayName("capture_rate")]
    [Category("ポケモン種族")]
    [Description("捕獲率")]
    public int? CaptureRate { get; set; }
    #endregion

    #region 基本なつき度
    /// <summary>
    /// 基本なつき度
    /// </summary>
    [JsonPropertyName("base_hapiness")]
    [DisplayName("base_hapiness")]
    [Category("ポケモン種族")]
    [Description("基本なつき度")]
    public int? BaseHappiness { get; set; }
    #endregion

    #region ベビーポケモンか
    /// <summary>
    /// ベビーポケモンか
    /// </summary>
    [JsonPropertyName("is_baby")]
    [DisplayName("is_baby")]
    [Category("ポケモン種族")]
    [Description("ベビーポケモンか")]
    public bool? IsBaby { get; set; }
    #endregion

    #region 伝説ポケモンか
    /// <summary>
    /// 伝説ポケモンか
    /// </summary>
    [JsonPropertyName("is_legendary")]
    [DisplayName("is_legendary")]
    [Category("ポケモン種族")]
    [Description("伝説ポケモンか")]
    public bool? IsLegendary { get; set; }
    #endregion

    #region 幻ポケモンか
    /// <summary>
    /// 幻ポケモンか
    /// </summary>
    [JsonPropertyName("is_mythical")]
    [DisplayName("is_mythical")]
    [Category("ポケモン種族")]
    [Description("幻ポケモンか")]
    public bool? IsMythical { get; set; }
    #endregion

    #region 孵化するまでに必要なサイクル数
    /// <summary>
    /// 孵化するまでに必要なサイクル数
    /// </summary>
    [JsonPropertyName("hatch_counter")]
    [DisplayName("hatch_counter")]
    [Category("ポケモン種族")]
    [Description("孵化するまでに必要なサイクル数")]
    public int? HatchCounter { get; set; }
    #endregion

    #region 性別によって見た目が変わるか
    /// <summary>
    /// 性別によって見た目が変わるか
    /// </summary>
    [JsonPropertyName("has_gender_differences")]
    [DisplayName("has_gender_differences")]
    [Category("ポケモン種族")]
    [Description("性別によって見た目が変わるか")]
    public bool? HasGenderDifferences { get; set; }
    #endregion

    #region ゲーム内でフォルム変更が可能か
    /// <summary>
    /// ゲーム内でフォルム変更が可能か
    /// </summary>
    [JsonPropertyName("has_forms_switchable")]
    [DisplayName("has_forms_switchable")]
    [Category("ポケモン種族")]
    [Description("ゲーム内でフォルム変更が可能か")]
    public bool HasFormsSwitchable { get; set; }
    #endregion

    #region 成長速度
    /// <summary>
    /// 成長速度
    /// </summary>
    [JsonPropertyName("has_forms_switchable")]
    [DisplayName("has_forms_switchable")]
    [Category("ポケモン種族")]
    [Description("成長速度")]
    public NamedAPIResource? GrowthRate { get; set; }
    #endregion

    #region ポケモン図鑑番号リスト
    /// <summary>
    /// ポケモン図鑑番号リスト
    /// </summary>
    [JsonPropertyName("pokedex_numbers")]
    [DisplayName("pokedex_numbers")]
    [Category("ポケモン種族")]
    [Description("ポケモン図鑑番号リスト")]
    public IReadOnlyList<PokemonSpeciesDexEntry>? PokedexNumbers { get; set; }
    #endregion

    #region 卵グループリスト
    /// <summary>
    /// 卵グループリスト
    /// </summary>
    [JsonPropertyName("egg_groups")]
    [DisplayName("egg_groups")]
    [Category("ポケモン種族")]
    [Description("卵グループリスト")]
    public IReadOnlyList<NamedAPIResource>? EggGroups { get; set; }
    #endregion

    #region 色
    /// <summary>
    /// 色
    /// </summary>
    [JsonPropertyName("color")]
    [DisplayName("color")]
    [Category("ポケモン種族")]
    [Description("色")]
    public NamedAPIResource? Color { get; set; }
    #endregion

    #region 形状
    /// <summary>
    /// 形状
    /// </summary>
    [JsonPropertyName("shape")]
    [DisplayName("shape")]
    [Category("ポケモン種族")]
    [Description("形状")]
    public NamedAPIResource? Shape { get; set; }
    #endregion

    #region 進化元
    /// <summary>
    /// 進化元
    /// </summary>
    [JsonPropertyName("evolves_from_species")]
    [DisplayName("evolves_from_species")]
    [Category("ポケモン種族")]
    [Description("進化元")]
    public NamedAPIResource? EvolvesFromSpecies { get; set; }
    #endregion

    #region 進化チェーン
    /// <summary>
    /// 進化チェーン
    /// </summary>
    [JsonPropertyName("evolves_from_species")]
    [DisplayName("evolves_from_species")]
    [Category("ポケモン種族")]
    [Description("進化元")]
    public NamedAPIResource? EvolutionChain { get; set; }
    #endregion

    #region 生息地
    /// <summary>
    /// 生息地
    /// </summary>
    [JsonPropertyName("habitat")]
    [DisplayName("habitat")]
    [Category("ポケモン種族")]
    [Description("生息地")]
    public NamedAPIResource? Habitat { get; set; }
    #endregion

    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    [DisplayName("generation")]
    [Category("ポケモン種族")]
    [Description("世代")]
    public NamedAPIResource? Generation { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("ポケモン種族")]
    [Description("言語ごとの名前リスト")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

}
