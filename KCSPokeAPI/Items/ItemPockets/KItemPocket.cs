using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテムポケット
/// </summary>
public class KItemPocket
{
    /// <summary>
    /// アイテムポケットID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// アイテムポケット名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// カテゴリリスト
    /// </summary>
    [JsonPropertyName("categories")]
    public required List<KNamedAPIResource> Categories { get; set; }

    /// <summary>
    /// アイテムポケット名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }


    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KItemPocket GetResource(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KItemPocket>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
} 
