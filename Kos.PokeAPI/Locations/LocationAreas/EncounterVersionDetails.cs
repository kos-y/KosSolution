using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.LocationAreas;

/// <summary>
/// バージョンごとの遭遇詳細
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EncounterVersionDetails
{
    #region 遭遇確立
    /// <summary>
    /// 遭遇確立
    /// </summary>
    [JsonPropertyName("rate")]
    [DisplayName("rate")]
    [Category("(基本)")]
    [Description("遭遇確立")]
    public int? Rate { get; set; }
    #endregion

    #region バージョン
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    [DisplayName("version")]
    [Category("(基本)")]
    [Description("バージョン")]
    public NamedAPIResource? Version { get; set; }
    #endregion
}
