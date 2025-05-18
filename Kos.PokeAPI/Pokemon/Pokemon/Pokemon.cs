using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Pokemon.PokeathlonStats;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン
/// </summary>
public class Pokemon
{
    #region ポケモンID
    /// <summary>
    /// ポケモンID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("ポケモン")]
    [Description("ポケモンID")]
    public int? Id { get; set; }
    #endregion

    #region ポケモンの名前
    /// <summary>
    /// ポケモンの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("ポケモン")]
    [Description("ポケモンの名前")]
    public string? Name { get; set; }
    #endregion

    #region 種族
    /// <summary>
    /// 種族
    /// </summary>
    [JsonPropertyName("species")]
    [DisplayName("species")]
    [Category("ポケモン")]
    [Description("種族")]
    public NamedAPIResource? Species { get; set; }
    #endregion

    #region ポケモン種族のデフォルトか
    /// <summary>
    /// ポケモン種族のデフォルトか
    /// </summary>
    [JsonPropertyName("is_default")]
    [DisplayName("is_default")]
    [Category("ポケモン")]
    [Description("ポケモン種族のデフォルトか")]
    public bool? IsDefault { get; set; }
    #endregion

    #region 基本経験値
    /// <summary>
    /// 基本経験値
    /// </summary>
    [JsonPropertyName("base_experience")]
    [DisplayName("base_experience")]
    [Category("ポケモン")]
    [Description("基本経験値")]
    public int? BaseExperience { get; set; }
    #endregion

    #region タイプリスト
    /// <summary>
    /// タイプリスト
    /// </summary>
    [JsonPropertyName("types")]
    [DisplayName("types")]
    [Category("ポケモン")]
    [Description("タイプリスト")]
    public IReadOnlyList<PokemonType>? Types { get; set; }
    #endregion

    #region 高さ
    /// <summary>
    /// 高さ
    /// </summary>
    [JsonPropertyName("height")]
    [DisplayName("height")]
    [Category("ポケモン")]
    [Description("高さ")]
    public int? Height { get; set; }
    #endregion

    #region 重さ
    /// <summary>
    /// 重さ
    /// </summary>
    [JsonPropertyName("weight")]
    [DisplayName("weight")]
    [Category("ポケモン")]
    [Description("重さ")]
    public int? Weight { get; set; }
    #endregion

    #region リージョンフォーム
    /// <summary>
    /// リージョンフォーム
    /// </summary>
    [JsonPropertyName("forms")]
    [DisplayName("forms")]
    [Category("ポケモン")]
    [Description("リージョンフォーム")]
    public IReadOnlyList<NamedAPIResource>? Forms { get; set; }
    #endregion

    #region 鳴き声
    /// <summary>
    /// 鳴き声
    /// </summary>
    [JsonPropertyName("cries")]
    [DisplayName("cries")]
    [Category("ポケモン")]
    [Description("鳴き声")]
    public PokemonCries? Cries { get; set; }
    #endregion

    #region スプライト
    /// <summary>
    /// スプライト
    /// </summary>
    [JsonPropertyName("sprites")]
    [DisplayName("sprites")]
    [Category("ポケモン")]
    [Description("スプライト")]
    public PokemonSprites? Sprites { get; set; }
    #endregion

    #region 全国図鑑の表示順番
    /// <summary>
    /// 全国図鑑の表示順番
    /// </summary>
    [JsonPropertyName("order")]
    [DisplayName("order")]
    [Category("ポケモン")]
    [Description("全国図鑑の表示順番")]
    public int? Order { get; set; }
    #endregion

    #region ステータスリスト
    /// <summary>
    /// ステータスリスト
    /// </summary>
    [JsonPropertyName("stats")]
    [DisplayName("stats")]
    [Category("ポケモン")]
    [Description("ステータスリスト")]
    public IReadOnlyList<PokemonStat>? Stats { get; set; }
    #endregion

    #region 特性リスト
    /// <summary>
    /// 特性リスト
    /// </summary>
    [JsonPropertyName("abilities")]
    [DisplayName("abilities")]
    [Category("ポケモン")]
    [Description("特性リスト")]
    public IReadOnlyList<PokemonAbility>? Abilities { get; set; }
    #endregion

    #region ゲーム内のインデックスリスト
    /// <summary>
    /// ゲーム内のインデックスリスト
    /// </summary>
    [JsonPropertyName("game_indices")]
    [DisplayName("game_indices")]
    [Category("ポケモン")]
    [Description("ゲーム内のインデックスリスト")]
    public IReadOnlyList<VersionGameIndex>? GameIndices { get; set; }
    #endregion

    #region 所持アイテムリスト
    /// <summary>
    /// 所持アイテムリスト
    /// </summary>
    [JsonPropertyName("held_items")]
    [DisplayName("held_items")]
    [Category("ポケモン")]
    [Description("処理アイテムリスト")]
    public IReadOnlyList<PokemonHeldItem>? HeldItems { get; set; }
    #endregion

    #region 遭遇場所
    /// <summary>
    /// 遭遇場所
    /// </summary>
    [JsonPropertyName("location_area_encounter")]
    [DisplayName("location_area_encounters")]
    [Category("ポケモン")]
    [Description("遭遇場所")]
    public string? LocationAreaEncounters { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    [DisplayName("moves")]
    [Category("ポケモン")]
    [Description("技リスト")]
    public IReadOnlyList<PokemonMove>? Moves { get; set; }
    #endregion

    #region 過去のタイプリスト
    /// <summary>
    /// 過去のタイプリスト
    /// </summary>
    [JsonPropertyName("past_types")]
    [DisplayName("past_types")]
    [Category("ポケモン")]
    [Description("過去のタイプリスト")]
    public IReadOnlyList<PokemonTypePast>? PastTypes { get; set; }
    #endregion

    #region 過去の特性
    /// <summary>
    /// 過去の特性
    /// </summary>
    [JsonPropertyName("past_abilities")]
    [DisplayName("past_abilities")]
    [Category("ポケモン")]
    [Description("過去の特性リスト")]
    public IReadOnlyList<PokemonAbilityPast>? PastAbilities { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Pokemon? GetResource(string url)
    {
        for (int i = 0; i < 5; i++) {
            try {
                string json = PokeAPIClient.GetAPIResourceUrl(url);

                return JsonSerializer.Deserialize<Pokemon>(json);
            } catch (JsonException) {
            }
        }

        return null;
    }
    #endregion
}
