using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// エンカウントの方法
/// </summary>
public class KEncounterMethod
{
    /// <summary>
    /// エンカウントの方法ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// エンカウントの方法名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 順番
    /// </summary>
    [JsonPropertyName("order")]
    public required int Order { get; set; }

    /// <summary>
    /// エンカウントの方法名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }


    /// <summary>
    /// エンカウントの方法リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>エンカウントの方法リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KEncounterMethod GetEncountMethod(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KEncounterMethod>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
