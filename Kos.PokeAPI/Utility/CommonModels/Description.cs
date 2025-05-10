using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 説明
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class Description
{
    // フィールド

    #region 説明
    /// <summary>
    /// 説明
    /// </summary>
    [JsonPropertyName("description")]
    [DisplayName("description")]
    [Category("(基本)")]
    [Description("説明")]
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


    // メソッド

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        return $"{Text}";
    }
    #endregion
}
