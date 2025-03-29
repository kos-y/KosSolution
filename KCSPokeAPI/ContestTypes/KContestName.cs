using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// コンテスト名
/// </summary>
public class KContestName
{
    /// <summary>
    /// コンテスト名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; } = string.Empty;

    /// <summary>
    /// 色
    /// </summary>
    [JsonPropertyName("color")]
    public required string Color { get; set; }

    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    public required KNamedAPIResource Language { get; set; }
}
