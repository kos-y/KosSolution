using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokeathlonStats;

/// <summary>
/// 性格が影響を与えるポケスロンのステータス
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class NaturePokeathlonStatAffect
{
    #region 性格
    /// <summary>
    /// 性格
    /// </summary>
    [JsonPropertyName("nature")]
    [DisplayName("nature")]
    [Category("(基本)")]
    [Description("性格")]
    public NamedAPIResource? Nature { get; set; }
    #endregion

    #region 最大変化量
    /// <summary>
    /// 最大変化量
    /// </summary>
    [JsonPropertyName("max_change")]
    [DisplayName("max_change")]
    [Category("(基本")]
    [Description("最大変化量")]
    public int? MaxChange { get; set; }
    #endregion
}
