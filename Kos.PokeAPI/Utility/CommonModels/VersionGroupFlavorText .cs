using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// バージョングループ フレーバーテキスト
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class VersionGroupFlavorText
{
    // フィールド

    #region テキスト
    /// <summary>
    /// テキスト
    /// </summary>
    [JsonPropertyName("text")]
    [DisplayName("text")]
    [Category("(基本)")]
    [Description("テキスト")]
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

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    [DisplayName("version_group")]
    [Category("(基本)")]
    [Description("バージョングループ")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion
}
