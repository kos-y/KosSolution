using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Berries.Berries;
using Kos.PokeAPI.Berries.BerryFirmnesses;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.BerryFlavors;

/// <summary>
/// きのみの味
/// </summary>
public class BerryFlavor
{
    #region きのみの味ID
    /// <summary>
    /// きのみの味ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("きのみの味ID")]
    public int? Id { get; set; }
    #endregion

    #region きのみの味の名前
    /// <summary>
    /// きのみの味の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("きのみの味の名前")]
    public string? Name { get; set; }
    #endregion

    #region きのみリスト
    /// <summary>
    /// きのみリスト
    /// </summary>
    [JsonPropertyName("berries")]
    [DisplayName("berries")]
    [Category("(基本)")]
    [Description("きのみリスト")]
    [TypeConverter(typeof(ListConverter<FlavorBerryMap>))]
    public IReadOnlyList<FlavorBerryMap>? Berries { get; set; }
    #endregion

    #region ポケモンコンテストの種類
    /// <summary>
    /// ポケモンコンテストの部門
    /// </summary>
    [JsonPropertyName("contest_type")]
    [DisplayName("contest_type")]
    [Category("(基本)")]
    [Description("ポケモンコンテストの種類")]
    public NamedAPIResource? ContestType { get; set; }
    #endregion

    #region 言語との名前リスト
    /// <summary>
    /// 言語との名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語との名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion


    // メソッド

    #region 木の実の味リソースの取得
    /// <summary>
    /// 木の実の味リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>木の実の味リソース</returns>
    public static BerryFlavor? GetBerryFlavor(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<BerryFlavor>(json);
    }
    #endregion
}
