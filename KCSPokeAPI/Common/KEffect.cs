using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// 効果
/// </summary>
public class KEffect
{
    /// <summary>
    /// 効果
    /// </summary>
    [JsonPropertyName("effect")]
    public required string Effect { get; set; }

    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    public required KNamedAPIResource Language { get; set; }
}
