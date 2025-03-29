using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 名前
/// </summary>
public class KName
{
    /// <summary>
    /// 名前
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; } = string.Empty;

    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    public required KNamedAPIResource Language { get; set; }
}
