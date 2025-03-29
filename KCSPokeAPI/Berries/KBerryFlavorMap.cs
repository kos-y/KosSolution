using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ベリー味マップ
/// </summary>
public class KBerryFlavorMap
{
    /// <summary>
    /// 味の強さ
    /// </summary>
    [JsonPropertyName("potency")]
    public required int Potency { get; set; }

    /// <summary>
    /// 味
    /// </summary>
    [JsonPropertyName("flavor")]
    public required KNamedAPIResource Flavor { get; set; }
}
