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
/// 遭遇条件確率
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EncounterMethodRate
{
    #region 遭遇方法
    /// <summary>
    /// 遭遇方法
    /// </summary>
    [JsonPropertyName("encounter_method")]
    [DisplayName("encounter_method")]
    [Category("(基本)")]
    [Description("遭遇方法")]
    public NamedAPIResource? EncounterMethod { get; set; }
    #endregion

    #region バージョンごとの遭遇詳細リスト
    /// <summary>
    /// バージョンごとのエンカウント詳細
    /// </summary>
    [JsonPropertyName("version_details")]
    [DisplayName("version_details")]
    [Category("(基本)")]
    [Description("バージョンごとの遭遇詳細リスト")]
    [TypeConverter(typeof(ListConverter<EncounterVersionDetails>))]
    public IReadOnlyList<EncounterVersionDetails>? VersionDetails { get; set; }
    #endregion
}
