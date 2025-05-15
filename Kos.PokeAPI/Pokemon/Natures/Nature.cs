using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Natures;

/// <summary>
/// 性格
/// </summary>
public class Nature
{
    #region 性格ID
    /// <summary>
    /// 性格ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("(基本)")]
    [Description("性格ID")]
    public int? Id { get; set; }
    #endregion

    #region 性格の名前
    /// <summary>
    /// 性格の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("(基本")]
    [Description("性格の名前")]
    public string? Name { get; set; }
    #endregion

    #region 上昇するステータス
    /// <summary>
    /// 上昇するステータス
    /// </summary>
    [JsonPropertyName("increased_stat")]
    [DisplayName("increased_stat")]
    [Category("ステータス")]
    [Description("上昇するステータス")]
    public NamedAPIResource? IncreasedStat { get; set; }
    #endregion

    #region 下降するステータス
    /// <summary>
    /// 下降するステータス
    /// </summary>
    [JsonPropertyName("decreased_stat")]
    [DisplayName("decreased_stat")]
    [Category("ステータス")]
    [Description("下降するステータス")]
    public NamedAPIResource? DecreasedStat { get; set; }
    #endregion

    #region 嫌いなきのみの味
    /// <summary>
    /// 嫌いなきのみの味
    /// </summary>
    [JsonPropertyName("hates_flavor")]
    [DisplayName("hates_flavor")]
    [Category("きのみ")]
    [Description("嫌いなきのみの味")]
    public NamedAPIResource? HatesFlavor { get; set; }
    #endregion

    #region 好きなきのみの味
    /// <summary>
    /// 好きなきのみの味
    /// </summary>
    [JsonPropertyName("likes_flavor")]
    [DisplayName("likes_flavor")]
    [Category("きのみ")]
    [Description("好きなきのみの味")]
    public NamedAPIResource? LikesFlavor { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region 影響を与えるポケスロンのステータスリスト
    /// <summary>
    /// 影響を与えるポケスロンのステータス
    /// </summary>
    [JsonPropertyName("pokeathlon_stat_changes")]
    [DisplayName("pokeathlon_stat_changes")]
    [Category("(基本")]
    [Description("影響を与えるポケスロンのステータスリスト")]
    public IReadOnlyList<NatureStatChange>? PokeathlonStatChanges { get; set; }
    #endregion

    #region 戦闘スタイルリスト
    /// <summary>
    /// 戦闘スタイルリスト
    /// </summary>
    [JsonPropertyName("move_battle_style_preferences")]
    [DisplayName("move_battle_style_preferences")]
    [Category("(基本)")]
    [Description("戦闘スタイル")]
    public IReadOnlyList<MoveBattleStylePreference>? MoveBattleStylePreferences { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Nature? GetResource(string url)
    {
        for (int i = 0; i < 5; i++) {
            try {
                string json = PokeAPIClient.GetAPIResourceUrl(url);

                return JsonSerializer.Deserialize<Nature>(json);
            } catch (JsonException) {
            }
        }

        return null;
    }
    #endregion
}
