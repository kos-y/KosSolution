using System.ComponentModel;
using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Contests.ContestTypes;

/// <summary>
/// コンテストの名前
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ContestName
{
    // フィールド

    #region コンテストの名前
    /// <summary>
    /// コンテスト名
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("(基本)")]
    [Description("コンテストの名前")]
    public string? Name { get; set; }
    #endregion

    #region 色
    /// <summary>
    /// 色
    /// </summary>
    [JsonPropertyName("color")]
    [DisplayName("color")]
    [Category("(基本)")]
    [Description("色")]
    public string? Color { get; set; }
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
        return $"{Name}";
    }
    #endregion
}
