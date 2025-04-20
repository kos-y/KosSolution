using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Berries.Berries;

/// <summary>
/// 木の実
/// </summary>
public class Berry
{
    // フィールド

    #region 木の実ID
    /// <summary>
    /// きのみID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 木の実名
    /// <summary>
    /// きのみ名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 成長時間
    /// <summary>
    /// 成長時間
    /// </summary>
    [JsonPropertyName("growth_time")]
    public int? GrowthTime { get; set; }
    #endregion

    #region 1回の収穫で取得できる最大数（第４世代以降）
    /// <summary>
    /// 1回の収穫で取得できる最大数（第４世代以降）
    /// </summary>
    [JsonPropertyName("max_harvest")]
    public int? MaxHarvest { get; set; }
    #endregion

    #region 「しぜんのめぐみ」の威力
    /// <summary>
    /// 「しぜんのめぐみ」の威力
    /// </summary>
    [JsonPropertyName("natural_gift_power")]
    public int? NaturalGiftPower { get; set; }
    #endregion

    #region きのみのサイズ
    /// <summary>
    /// きのみのサイズ
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
    #endregion

    #region 滑らかさ
    /// <summary>
    /// 滑らかさ
    /// </summary>
    [JsonPropertyName("smoothness")]
    public int? Smoothness { get; set; }
    #endregion

    #region 土壌を乾燥させる速度
    /// <summary>
    /// 土壌を乾燥させる速度
    /// </summary>
    [JsonPropertyName("soil_dryness")]
    public int? SoilDryness { get; set; }
    #endregion

    #region 固さ
    /// <summary>
    /// 固さ
    /// </summary>
    [JsonPropertyName("firmness")]
    public NamedAPIResource? Firmness { get; set; }
    #endregion

    #region 味リスト
    /// <summary>
    /// 味リスト
    /// </summary>
    [JsonPropertyName("flavors")]
    public List<BerryFlavorMap>? Flavors { get; set; }
    #endregion

    #region アイテム
    /// <summary>
    /// アイテム
    /// </summary>
    [JsonPropertyName("item")]
    public NamedAPIResource? Item { get; set; }
    #endregion

    #region 「しぜんのめぐみ」の技タイプ
    /// <summary>
    /// 「しぜんのめぐみ」の技タイプ
    /// </summary>
    [JsonPropertyName("natural_gift_type")]
    public NamedAPIResource? NaturalGiftType { get; set; }
    #endregion


    // メソッド

    #region 木の実リソースの取得
    /// <summary>
    /// 木の実リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>木の実リソース</returns>
    public static Berry? GetBerry(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Berry>(json);
    }
    #endregion
}
