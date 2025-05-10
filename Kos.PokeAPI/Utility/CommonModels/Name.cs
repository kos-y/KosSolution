using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 名前
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class Name
{
    // フィールド

    #region 名前
    /// <summary>
    /// 名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("基本")]
    [Description("名前")]
    public string? Text { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    [DisplayName("language")]
    [Category("基本")]
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
        return Text;
    }
    #endregion
}
