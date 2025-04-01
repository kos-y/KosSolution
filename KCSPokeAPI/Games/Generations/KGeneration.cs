using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// 世代
/// </summary>
public class KGeneration
{
    /// <summary>
    /// 世代ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// 世代名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 特性リスト
    /// </summary>
    [JsonPropertyName("abilities")]
    public required List<KNamedAPIResource> Abilities { get; set; }

    /// <summary>
    /// 世代名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// メイン地域
    /// </summary>
    [JsonPropertyName("main_region")]
    public required KNamedAPIResource MainRegion { get; set; }

    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    public required List<KNamedAPIResource> Moves { get; set; }

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    public required List<KNamedAPIResource> PokemonSpecies { get; set; }

    /// <summary>
    /// タイプリスト
    /// </summary>
    [JsonPropertyName("types")]
    public required List<KNamedAPIResource> Types { get; set; }

    /// <summary>
    /// バージョングループリスト
    /// </summary>
    [JsonPropertyName("version_groups")]
    public required List<KNamedAPIResource> VersionGroups { get; set; }


    /// <summary>
    /// 世代リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>世代リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KGeneration GetGeneration(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KGeneration>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
