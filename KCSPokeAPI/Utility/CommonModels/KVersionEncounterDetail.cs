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
public class KVersionEncounterDetail
{
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    public required KNamedAPIResource Version { get; set; }

    /// <summary>
    /// エンカウントの最大確率
    /// </summary>
    [JsonPropertyName("max_chance")]
    public required int MaxChance { get; set; }

    /// <summary>
    /// エンカウントの詳細
    /// </summary>
    [JsonPropertyName("encounter_details")]
    public required List<KEncounter> EncounterDetails { get; set; } = [];
}
