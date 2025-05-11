using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// エンカウント バージョンごとの詳細
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class VersionEncounterDetail
{
    // フィールド

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

    #region 遭遇最大確立
    /// <summary>
    /// 遭遇最大確率
    /// </summary>
    [JsonPropertyName("max_chance")]
    [DisplayName("max_chance")]
    [Category("(基本)")]
    [Description("遭遇最大確率")]
    public int? MaxChance { get; set; }
    #endregion

    #region 遭遇情報詳細リスト
    /// <summary>
    /// 遭遇情報詳細リスト
    /// </summary>
    [JsonPropertyName("encounter_details")]
    [DisplayName("encounter_details")]
    [Category("(基本)")]
    [Description("遭遇情報詳細リスト")]
    [TypeConverter(typeof(ListConverter<Encounter>))]
    public IReadOnlyList<Encounter>? EncounterDetails { get; set; }
    #endregion
}
