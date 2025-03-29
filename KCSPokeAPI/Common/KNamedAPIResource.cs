using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
