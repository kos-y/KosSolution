using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// エンカウント条件
/// </summary>
public class KEncounterCondition
{
    /// <summary>
    /// エンカウント条件)D
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// エンカウント条件名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// エンカウント条件名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// エンカウント条件値リスト
    /// </summary>
    [JsonPropertyName("values")]
    public required List<KNamedAPIResource> Values { get; set; }


    /// <summary>
    /// エンカウント条件リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>エンカウント条件リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KEncounterCondition GetEncountCondition(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KEncounterCondition>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
