using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 効果
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class Effect
{
    #region 効果
    /// <summary>
    /// 効果
    /// </summary>
    [JsonPropertyName("effect")]
    [DisplayName("effect")]
    [Category("(基本)")]
    [Description("効果")]
    public string? Text { get; set; }
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
