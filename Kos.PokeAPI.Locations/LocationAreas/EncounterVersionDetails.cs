using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.LocationAreas;

/// <summary>
/// バージョンごとの遭遇詳細
/// </summary>
public class EncounterVersionDetails
{
    #region 遭遇確立
    /// <summary>
    /// 遭遇確立
    /// </summary>
    [JsonPropertyName("rate")]
    public int? Rage { get; set; }
    #endregion

    #region バージョン
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    public NamedAPIResource? Version { get; set; }
    #endregion
}
