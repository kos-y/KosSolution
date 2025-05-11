using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// 技が影響を与えるステータス
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class MoveStatChange
{
    #region 変化量
    /// <summary>
    /// 変化量
    /// </summary>
    [JsonPropertyName("change")]
    [DisplayName("change")]
    [Category("(基本)")]
    [Description("変化量")]
    public int? Change { get; set; }
    #endregion

    #region 影響を与えるステータス
    /// <summary>
    /// 影響を与えるステータス
    /// </summary>
    [JsonPropertyName("stat")]
    [DisplayName("stat")]
    [Category("(基本)")]
    [Description("影響を与えるステータス")]
    public NamedAPIResource? Stat { get; set; }
    #endregion
}
