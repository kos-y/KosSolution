using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Berries.Berries;

/// <summary>
/// きのみ
/// </summary>
public class Berry
{
    // フィールド

    #region きのみID
    /// <summary>
    /// きのみID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("きのみID")]
    public int? Id { get; set; }
    #endregion

    #region きのみの名前
    /// <summary>
    /// きのみの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("きのみの名前")]
    public string? Name { get; set; }
    #endregion

    #region 成長時間
    /// <summary>
    /// 成長時間
    /// </summary>
    [JsonPropertyName("growth_time")]
    [DisplayName("growth_time")]
    [Category("(基本)")]
    [Description("成長時間")]
    public int? GrowthTime { get; set; }
    #endregion

    #region 1回の収穫で取得できる最大数（第４世代以降）
    /// <summary>
    /// 1回の収穫で取得できる最大数（第４世代以降）
    /// </summary>
    [JsonPropertyName("max_harvest")]
    [DisplayName("max_harvest")]
    [Category("(基本)")]
    [Description("1回の収穫で取得できる最大数（第４世代以降）")]
    public int? MaxHarvest { get; set; }
    #endregion

    #region 「しぜんのめぐみ」の威力
    /// <summary>
    /// 「しぜんのめぐみ」の威力
    /// </summary>
    [JsonPropertyName("natural_gift_power")]
    [DisplayName("natural_gift_power")]
    [Category("しぜんのめぐみ")]
    [Description("「しぜんのめぐみ」の威力")]
    public int? NaturalGiftPower { get; set; }
    #endregion

    #region きのみのサイズ
    /// <summary>
    /// きのみのサイズ
    /// </summary>
    [JsonPropertyName("size")]
    [DisplayName("size")]
    [Category("(基本)")]
    [Description("きのみのサイズ")]
    public int? Size { get; set; }
    #endregion

    #region きのみの滑らかさ
    /// <summary>
    /// きのみの滑らかさ
    /// </summary>
    [JsonPropertyName("smoothness")]
    [DisplayName("smoothness")]
    [Category("(基本)")]
    [Description("きのみの滑らかさ")]
    public int? Smoothness { get; set; }
    #endregion

    #region 土壌を乾燥させる速度
    /// <summary>
    /// 土壌を乾燥させる速度
    /// </summary>
    [JsonPropertyName("soil_dryness")]
    [DisplayName("soil_dryness")]
    [Category("(基本)")]
    [Description("土壌を乾燥させる速度")]
    public int? SoilDryness { get; set; }
    #endregion

    #region きのみの硬さ
    /// <summary>
    /// きのみの硬さ
    /// </summary>
    [JsonPropertyName("firmness")]
    [DisplayName("firmness")]
    [Category("(基本)")]
    [Description("きのみの硬さ")]
    public NamedAPIResource? Firmness { get; set; }
    #endregion

    #region きのみの味リスト
    /// <summary>
    /// きのみの味リスト
    /// </summary>
    [JsonPropertyName("flavors")]
    [DisplayName("flavors")]
    [Category("(基本)")]
    [Description("きのみの味リスト")]
    [TypeConverter(typeof(ListConverter<BerryFlavorMap>))]
    public IReadOnlyList<BerryFlavorMap>? Flavors { get; set; }
    #endregion

    #region アイテム
    /// <summary>
    /// アイテム
    /// </summary>
    [JsonPropertyName("item")]
    [DisplayName("item")]
    [Category("(基本)")]
    [Description("アイテム")]
    public NamedAPIResource? Item { get; set; }
    #endregion

    #region 「しぜんのめぐみ」の技タイプ
    /// <summary>
    /// 「しぜんのめぐみ」の技タイプ
    /// </summary>
    [JsonPropertyName("natural_gift_type")]
    [DisplayName("natural_gift_type")]
    [Category("しぜんのめぐみ")]
    [Description("「しぜんのめぐみ」の技タイプ")]
    public NamedAPIResource? NaturalGiftType { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Berry? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Berry>(json);
    }
    #endregion
}
