using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.LocationAreas;

/// <summary>
/// 遭遇ポケモン
/// </summary>
public class PokemonEncounter
{
    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    public NamedAPIResource? Pokemon { get; set; }
    #endregion

    #region バージョンごとのエンカウント詳細
    /// <summary>
    /// バージョンごとのエンカウント詳細
    /// </summary>
    [JsonPropertyName("version_details")]
    public List<VersionEncounterDetail>? VersionDetails { get; set; }
    #endregion
}
