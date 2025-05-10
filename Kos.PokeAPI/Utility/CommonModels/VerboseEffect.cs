using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 効果 詳細
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class VerboseEffect
{
    // フィールド

    #region 効果 詳細
    /// <summary>
    /// 効果 詳細
    /// </summary>
    [JsonPropertyName("effect")]
    [DisplayName("effect")]
    [Category("(基本)")]
    [Description("効果 詳細")]
    public string? Effect { get; set; }
    #endregion

    #region 効果 簡易
    /// <summary>
    /// 効果 簡易
    /// </summary>
    [JsonPropertyName("short_effect")]
    [DisplayName("short_effect")]
    [Category("(基本)")]
    [Description("効果 簡易")]
    public string? ShortEffect { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    [DisplayName("language")]
    [Category("(基本)")]
    [Description("言語")]
    public NamedAPIResource? Language { get; set; }
    #endregion
}
