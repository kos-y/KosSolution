using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// アイテムスプライト
/// </summary>
public class KItemSprites
{
    /// <summary>
    /// デフォルト
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }
}
