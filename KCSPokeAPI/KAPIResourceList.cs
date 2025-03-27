using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// APIリソースリスト
/// </summary>
public class KAPIResourceList
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
    public required List<KAPIResource> Results { get; set; }
}
