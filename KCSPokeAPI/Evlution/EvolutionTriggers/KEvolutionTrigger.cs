using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 進化トリガー
/// </summary>
public class KEvolutionTrigger
{
    /// <summary>
    /// 進化トリガーID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// 進化トリガー名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 進化トリガー名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    public required List<KNamedAPIResource> PokemonSpecies { get; set; }


    /// <summary>
    /// 進化トリガーリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>進化トリガーリソース</returns>
    /// <exception cref="Exception"></exception>
    public static KEvolutionTrigger GetEvolutionTrigger(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KEvolutionTrigger>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
