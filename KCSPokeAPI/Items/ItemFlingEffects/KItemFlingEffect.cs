using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテムを投げつけた時の効果
/// </summary>
public class KItemFlingEffect
{
    /// <summary>
    /// 効果ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// 効果名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    public required List<KEffect> EffectEntries { get; set; }

    /// <summary>
    /// アイテムリスト
    /// </summary>
    [JsonPropertyName("items")]
    public required List<KNamedAPIResource> Items { get; set; }


    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KItemFlingEffect GetResource(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KItemFlingEffect>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
