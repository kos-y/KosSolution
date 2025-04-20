using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Berries.BerryFirmnesses;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.BerryFlavors;

/// <summary>
/// 木の実の味
/// </summary>
public class BerryFlavor
{
    #region きのみの味ID
    /// <summary>
    /// きのみの味ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region きのみの味名
    /// <summary>
    /// きのみの味名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region きのみリスト
    /// <summary>
    /// きのみリスト
    /// </summary>
    [JsonPropertyName("berries")]
    public List<FlavorBerryMap>? Berries { get; set; }
    #endregion

    #region ポケモンコンテストの部門
    /// <summary>
    /// ポケモンコンテストの部門
    /// </summary>
    [JsonPropertyName("contest_type")]
    public NamedAPIResource? ContestType { get; set; }
    #endregion

    #region 名前リスト
    /// <summary>
    /// きのみの味名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
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
