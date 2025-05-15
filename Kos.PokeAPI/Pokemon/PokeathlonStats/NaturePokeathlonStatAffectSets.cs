using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokeathlonStats;

/// <summary>
/// 性格が影響を与えるポケスロンのステータスセット
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class NaturePokeathlonStatAffectSets
{
    #region 上昇する性格リスト
    /// <summary>
    /// 上昇する性格リスト
    /// </summary>
    [JsonPropertyName("increase")]
    [DisplayName("increase")]
    [Category("(基本)")]
    [Description("上昇する性格リスト")]
    [TypeConverter(typeof(ListConverter<NaturePokeathlonStatAffect>))]
    public IReadOnlyList<NaturePokeathlonStatAffect>? Increase { get; set; }
    #endregion

    #region 下降する性格リスト
    /// <summary>
    /// 下降する性格リスト
    /// </summary>
    [JsonPropertyName("decrease")]
    [DisplayName("decrease")]
    [Category("(基本)")]
    [Description("下降する性格リスト")]
    [TypeConverter(typeof(ListConverter<NaturePokeathlonStatAffect>))]
    public IReadOnlyList<NaturePokeathlonStatAffect>? Decrease { get; set; }
    #endregion
}
