using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// エンカウント条件値
/// </summary>
public class KEncounterConditionValue
{
    /// <summary>
    /// エンカウント条件値ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// エンカウント条件値名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// エンカウント条件
    /// </summary>
    [JsonPropertyName("condition")]
    public required KNamedAPIResource Condition { get; set; }

    /// <summary>
    /// エンカウント条件値名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }


    /// <summary>
    /// エンカウント条件値リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>エンカウント条件値リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KEncounterConditionValue GetEncountConditionValue(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KEncounterConditionValue>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
