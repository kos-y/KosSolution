using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// API リソース
/// </summary>
public class KAPIResource
{
    /// <summary>
    /// URL
    /// </summary>
    [JsonPropertyName("url")]
    public required string URL { get; set; } = string.Empty;
}
