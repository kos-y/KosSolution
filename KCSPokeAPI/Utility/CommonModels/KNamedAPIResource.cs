using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// 名前付きAPIリソース
/// </summary>
public class KNamedAPIResource
{
    /// <summary>
    /// リソース名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// URL
    /// </summary>
    [JsonPropertyName("url")]
    public required string URL { get; set; }
}
