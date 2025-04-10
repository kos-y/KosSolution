using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// バージョンごとのエンカウント詳細
/// </summary>
public class KEncounterVersionDetails
{
    /// <summary>
    /// エンカウント確率
    /// </summary>
    [JsonPropertyName("rate")]
    public required int Rage { get; set; }

    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    public required KNamedAPIResource Version { get; set; }
}
