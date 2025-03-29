using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 名前付きAPIリソースリスト
/// </summary>
public class KNamedAPIResourceList
{
    /// <summary>
    /// 件数
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>
    /// 次ページへのURL
    /// </summary>
    [JsonPropertyName("next")]
    public required string? Next { get; set; }

    /// <summary>
    /// 前ページへのURL
    /// </summary>
    [JsonPropertyName("previous")]
    public required string? Previous { get; set; }

    /// <summary>
    /// 結果リスト
    /// </summary>
    [JsonPropertyName("results")]
    public required List<KNamedAPIResource> Results { get; set; }
}
