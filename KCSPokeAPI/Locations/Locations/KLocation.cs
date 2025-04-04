using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 場所
/// </summary>
public class KLocation
{
    /// <summary>
    /// 場所ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// 場所名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 地域
    /// </summary>
    [JsonPropertyName("region")]
    public required KNamedAPIResource Region { get; set; }

    /// <summary>
    /// 場所名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// 世代ごとのゲームIndexリスト
    /// </summary>
    [JsonPropertyName("game_indices")]
    public required List<KGenerationGameIndex> GameIndices { get; set; }

    /// <summary>
    /// エリアリスト
    /// </summary>
    [JsonPropertyName("areas")]
    public required List<KNamedAPIResource> Areas { get; set; }


    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KLocation GetResource(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KLocation>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
