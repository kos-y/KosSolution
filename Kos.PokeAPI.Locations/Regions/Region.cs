using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Locations.PalParkAreas;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.Regions;

/// <summary>
/// 地域
/// </summary>
public class Region
{
    #region 地域ID
    /// <summary>
    /// 地域ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 地域名
    /// <summary>
    /// 地域名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 場所リスト
    /// <summary>
    /// 場所リスト
    /// </summary>
    [JsonPropertyName("locations")]
    public List<NamedAPIResource>? Locations { get; set; }
    #endregion

    #region 地域名リスト
    /// <summary>
    /// 地域名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region メインの世代
    /// <summary>
    /// メインの世代
    /// </summary>
    [JsonPropertyName("main_generation")]
    public NamedAPIResource? MainGeneration { get; set; }
    #endregion

    #region ポケモン図鑑リスト
    /// <summary>
    /// ポケモン図鑑リスト
    /// </summary>
    [JsonPropertyName("pokedexes")]
    public List<NamedAPIResource>? Pokedexes { get; set; }
    #endregion

    #region バージョングループリスト
    /// <summary>
    /// バージョングループリスト
    /// </summary>
    [JsonPropertyName("version_groups")]
    public List<NamedAPIResource>? VersionGroups { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Region? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Region>(json);
    }
    #endregion
}
