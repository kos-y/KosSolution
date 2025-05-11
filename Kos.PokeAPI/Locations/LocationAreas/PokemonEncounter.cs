using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.LocationAreas;

/// <summary>
/// 遭遇ポケモン
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonEncounter
{
    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    [DisplayName("pokemon")]
    [Category("(基本)")]
    [Description("ポケモン")]
    public NamedAPIResource? Pokemon { get; set; }
    #endregion

    #region バージョンごとの遭遇情報詳細
    /// <summary>
    /// バージョンごとの遇情報詳細
    /// </summary>
    [JsonPropertyName("version_details")]
    [DisplayName("version_details")]
    [Category("(基本)")]
    [Description("バージョンごとの遇情報詳細")]
    [TypeConverter(typeof(ListConverter<VersionEncounterDetail>))]
    public IReadOnlyList<VersionEncounterDetail>? VersionDetails { get; set; }
    #endregion
}
