using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// きのみの固さ
/// </summary>
public class KBerryFirmness
{
    /// <summary>
    /// きのみの固さID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// きのみの固さ名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// きのみリスト
    /// </summary>
    [JsonPropertyName("berries")]
    public required List<KNamedAPIResource> Berries { get; set; }

    /// <summary>
    /// きのみの固さ名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }


    /// <summary>
    /// きのみの固さリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>きのみの固さ</returns>
    /// <exception cref="Exception"></exception>
    public static KBerryFirmness GetBerryFirmness(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KBerryFirmness>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
