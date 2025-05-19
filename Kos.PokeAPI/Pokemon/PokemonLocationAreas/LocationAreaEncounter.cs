using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonLocationAreas;

/// <summary>
/// 生息地
/// </summary>
public class LocationAreaEncounter
{
    #region 場所エリア
    /// <summary>
    /// 場所エリア
    /// </summary>
    [JsonPropertyName("location_area")]
    [DisplayName("location_area")]
    [Category("生息地")]
    [Description("場所エリア")]
    public NamedAPIResource? LocationArea { get; set; }
    #endregion

    #region バージョンごとの生息情報
    /// <summary>
    /// バージョンごとの生息情報
    /// </summary>
    [JsonPropertyName("version_details")]
    [DisplayName("version_details")]
    [Category("生息地")]
    [Description("バージョンごとの生息地")]
    public IReadOnlyList<VersionEncounterDetail>? VersionDetails { get; set; }
    #endregion
}
