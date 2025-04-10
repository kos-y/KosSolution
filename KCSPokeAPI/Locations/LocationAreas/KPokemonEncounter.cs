using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウントポケモン
/// </summary>
public class KPokemonEncounter
{
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    public required KNamedAPIResource Pokemon { get; set; }

    /// <summary>
    /// バージョンごとのエンカウント詳細
    /// </summary>
    [JsonPropertyName("version_details")]
    public required List<KVersionEncounterDetail> VersionDetails { get; set; } = [];
}
