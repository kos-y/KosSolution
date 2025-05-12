using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Pokemon.Abilities;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Characteristics;

/// <summary>
/// 個性
/// </summary>
public class Characteristic
{
    #region 個性ID
    /// <summary>
    /// 個性ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("(基本)")]
    [Description("個性ID")]
    public int? Id { get; set; }
    #endregion

    #region 個性の条件値（個体値を５で割った余り）
    /// <summary>
    /// 個性の条件値（個体値を５で割った余り）
    /// </summary>
    [JsonPropertyName("gene_modulo")]
    [DisplayName("gene_modulo")]
    [Category("(基本)")]
    [Description("個性の条件値（個体値を５で割った余り）")]
    public int? GeneModulo { get; set; }
    #endregion

    #region 特性に該当する数値リスト
    /// <summary>
    /// 特性に該当する数値リスト
    /// </summary>
    [JsonPropertyName("possible_values")]
    [DisplayName("possible_values")]
    [Category("(基本)")]
    [Description("特性に該当する数値リスト")]
    [TypeConverter(typeof(ListConverter<int>))]
    public IReadOnlyList<int>? PossibleValues { get; set; }
    #endregion

    #region 最高ステータス
    /// <summary>
    /// 最高ステータス
    /// </summary>
    [JsonPropertyName("highest_stat")]
    [DisplayName("highest_stat")]
    [Category("(基本)")]
    [Description("最高ステータス")]
    public NamedAPIResource? HighestStat { get; set; }
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


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Characteristic? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Characteristic>(json);
    }
    #endregion
}
