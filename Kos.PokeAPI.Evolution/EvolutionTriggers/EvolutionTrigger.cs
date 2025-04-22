using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Evolution.EvolutionTriggers;

/// <summary>
/// 進化トリガー
/// </summary>
public class EvolutionTrigger
{
    // フィールド

    #region 進化トリガーID
    /// <summary>
    /// 進化トリガーID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 進化トリガー名
    /// <summary>
    /// 進化トリガー名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 進化トリガー名リスト
    /// <summary>
    /// 進化トリガー名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    public List<NamedAPIResource>? PokemonSpecies { get; set; }
    #endregion


    // メソッド

    #region 進化トリガーリソースの取得
    /// <summary>
    /// 進化トリガーリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>進化トリガーリソース</returns>
    public static EvolutionTrigger? GetEvolutionTrigger(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<EvolutionTrigger>(json);
    }
    #endregion
}
