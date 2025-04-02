using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// バージョン
/// </summary>
public class KVersion
{
    /// <summary>
    /// バージョンID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// バージョン名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// バージョン名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    public required KNamedAPIResource VersionGroup { get; set; }


    /// <summary>
    /// バージョンリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>バージョンリソース</returns>
    /// <exception cref="Exception"></exception>
    public static KVersion GetVersion(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KVersion>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
