using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// きのみの味
/// </summary>
public class KBerryFlavor
{
    /// <summary>
    /// きのみの味ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID {  get; set; }

    /// <summary>
    /// きのみの味名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// きのみリスト
    /// </summary>
    [JsonPropertyName("berries")]
    public required List<KFlavorBerryMap> Berries { get; set; }

    /// <summary>
    /// ポケモンコンテストの部門
    /// </summary>
    [JsonPropertyName("contest_type")]
    public required KNamedAPIResource ContestType { get; set; }

    /// <summary>
    /// きのみの味名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }


    /// <summary>
    /// きのみの味リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>きのみの味リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KBerryFlavor GetBerryFlavor(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KBerryFlavor>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
