using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Berries.Berries;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.BerryFirmnesses;

/// <summary>
/// 木の実の型さん
/// </summary>
public class BerryFirmness
{
    // フィールド

    #region 木の実の固さID
    /// <summary>
    /// きのみの固さID
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; set; }
    #endregion

    #region 木の実の固さ名
    /// <summary>
    /// きのみの固さ名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    #endregion

    #region 木の実リスト
    /// <summary>
    /// きのみリスト
    /// </summary>
    [JsonPropertyName("berries")]
    public required List<NamedAPIResource> Berries { get; set; }
    #endregion

    #region 名前リスト
    /// <summary>
    /// きのみの固さ名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<Name> Names { get; set; }
    #endregion


    // メソッド

    #region 木の実の固さリソースの取得
    /// <summary>
    /// 木の実の固さリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>木の実の固さリソース</returns>
    public static BerryFirmness? GetBerryFirmness(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<BerryFirmness>(json);
    }
    #endregion
}
