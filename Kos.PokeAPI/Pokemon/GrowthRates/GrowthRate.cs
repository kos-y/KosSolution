using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Pokemon.Genders;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.GrowthRates;

/// <summary>
/// レベルアップに必要な経験値の増加量
/// </summary>
public class GrowthRate
{
    #region 経験値増加量ID
    /// <summary>
    /// 経験値増加量ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("経験値増加量ID")]
    public int? Id { get; set; }
    #endregion

    #region 経験値増加量の名前
    /// <summary>
    /// 経験値増加量の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("経験値増加量の名前")]
    public string? Name { get; set; }
    #endregion

    #region 計算種別
    /// <summary>
    /// 計算種別
    /// </summary>
    [JsonPropertyName("formula")]
    [DisplayName("formula")]
    [Category("(基本)")]
    [Description("計算種別")]
    public string? Formula { get; set; }
    #endregion

    #region 言語ごとの説明リスト
    /// <summary>
    /// 言語ごとの説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    [DisplayName("descriptions")]
    [Category("(基本)")]
    [Description("言語ごとの説明リスト")]
    [TypeConverter(typeof(ListConverter<Description>))]
    public IReadOnlyList<Description>? Descriptions { get; set; }
    #endregion

    #region レベルごとの経験値リスト
    /// <summary>
    /// レベルごとの経験値リスト
    /// </summary>
    [JsonPropertyName("levels")]
    [DisplayName("levels")]
    [Category("(基本)")]
    [Description("レベルごとの経験値リスト")]
    [TypeConverter(typeof(ListConverter<Description>))]
    public List<GrowthRateExperienceLevel>? Levels { get; set; }
    #endregion

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [DisplayName("pokemon_species")]
    [Category("(基本)")]
    [Description("ポケモン種族リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public List<NamedAPIResource>? PokemonSpecies { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static GrowthRate? GetResource(string url)
    {
        for (int i = 0; i < 5; i++) {
            try {
                string json = PokeAPIClient.GetAPIResourceUrl(url);

                return JsonSerializer.Deserialize<GrowthRate>(json);
            } catch (JsonException) {
            }
        }

        return null;
    }
    #endregion
}
