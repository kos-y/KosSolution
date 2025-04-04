﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテム特性
/// </summary>
public class KItemAttribute
{
    /// <summary>
    /// アイテム特性ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// アイテム特性名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// アイテムリスト
    /// </summary>
    [JsonPropertyName("items")]
    public required List<KNamedAPIResource> Items { get; set; }

    /// <summary>
    /// アイテム特性名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    public required List<KDescription> Descriptions { get; set; }


    /// <summary>
    /// アイテムリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>アイテムリソース</returns>
    /// <exception cref="Exception"></exception>
    public static KItemAttribute GetItemAttribute(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KItemAttribute>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
