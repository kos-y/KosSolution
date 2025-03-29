using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// フレーバーテキスト
/// </summary>
public class KFlavorText
{
    /// <summary>
    /// フレーバーテキスト
    /// </summary>
    [JsonPropertyName("flavor_text")]
    public required string FlavorText { get; set; }

    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    public required KNamedAPIResource Language { get; set; }
}
