using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 名前付き APIリソース
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class NamedAPIResource
{
    // フィールド

    #region リソースの名前
    /// <summary>
    /// リソースの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("基本")]
    [Description("リソースの名前")]
    public string? Name { get; set; }
    #endregion

    #region リソースへのURL
    /// <summary>
    /// リソースへのURL
    /// </summary>
    [JsonPropertyName("url")]
    [DisplayName("url")]
    [Category("基本")]
    [Description("リソースへのURL")]
    public string? Url { get; set; }
    #endregion


    // メソッド

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        return Name ?? Url ?? string.Empty;
        ;
    }
    #endregion
}
