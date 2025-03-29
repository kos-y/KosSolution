using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// コンテストの部門
/// </summary>
public class KContestType
{
    /// <summary>
    /// コンテストの部門ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// コンテストの部門名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// きのみの味
    /// </summary>
    [JsonPropertyName("berry_flavor")]
    public required KNamedAPIResource BerryFlavor { get; set; }

    /// <summary>
    /// コンテストの部門名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KContestName> Names { get; set; }


    /// <summary>
    /// コンテストタイプリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>コンテストタイプリソース</returns>
    /// <exception cref="Exception"></exception>
    public static KContestType GetContestType(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KContestType>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
