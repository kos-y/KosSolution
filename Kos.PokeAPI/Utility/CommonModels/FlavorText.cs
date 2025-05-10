using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// フレーバーテキスト
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class FlavorText
{
    // フィールド

    #region フレーバーテキスト
    /// <summary>
    /// フレーバーテキスト
    /// </summary>
    [JsonPropertyName("flavor_text")]
    [DisplayName("flavor_text")]
    [Category("(基本)")]
    [Description("フレーバーテキスト")]
    public string? Text { get; set; }
    #endregion

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
