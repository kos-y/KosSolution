using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウント方法の確率
/// </summary>
public class KEncounterMethodRate
{
    /// <summary>
    /// エンカウント方法
    /// </summary>
    [JsonPropertyName("encounter_method")]
    public required KNamedAPIResource EncounterMethod { get; set; }

    /// <summary>
    /// バージョンごとのエンカウント詳細
    /// </summary>
    [JsonPropertyName("version_details")]
    public required List<KEncounterVersionDetails> VersionDetails { get; set; }
}
