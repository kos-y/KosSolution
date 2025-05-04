using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Locations.Locations;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.PalParkAreas;

/// <summary>
/// パルパークエリア
/// </summary>
public class PalParkArea
{
    #region パルパークエリアID
    /// <summary>
    /// パルパークエリアID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region パルパークエリア名
    /// <summary>
    /// パルパークエリア名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region パルパークエリア名リスト
    /// <summary>
    /// パルパークエリア名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region 遭遇するポケモン種族リスト
    /// <summary>
    /// 遭遇するポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_encounters")]
    public List<PalParkEncounterSpecies>? PokemonEncounters { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static PalParkArea? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<PalParkArea>(json);
    }
    #endregion
}
