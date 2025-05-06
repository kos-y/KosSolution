using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.LocationAreas;

/// <summary>
/// 遭遇条件確率
/// </summary>
public class EncounterMethodRate
{
    #region エンカウント方法
    /// <summary>
    /// エンカウント方法
    /// </summary>
    [JsonPropertyName("encounter_method")]
    public NamedAPIResource? EncounterMethod { get; set; }
    #endregion

    #region バージョンごとのエンカウント詳細
    /// <summary>
    /// バージョンごとのエンカウント詳細
    /// </summary>
    [JsonPropertyName("version_details")]
    public List<EncounterVersionDetails>? VersionDetails { get; set; }
    #endregion
}
