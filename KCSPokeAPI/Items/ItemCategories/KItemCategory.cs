using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテムカテゴリ
/// </summary>
public class KItemCategory
{
    /// <summary>
    /// アイテムカテゴリID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// アイテムカテゴリ名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// アイテムリスト
    /// </summary>
    [JsonPropertyName("items")]
    public required List<KNamedAPIResource> Items { get; set; }

    /// <summary>
    /// アイテムカテゴリ名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// ポケット
    /// </summary>
    [JsonPropertyName("pocket")]
    public required KNamedAPIResource Pocket { get; set; }


    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KItemCategory GetItemCategory(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KItemCategory>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
