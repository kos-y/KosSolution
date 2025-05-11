using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 遭遇
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class Encounter
{
    #region 最低レベル
    /// <summary>
    /// 最低レベル
    /// </summary>
    [JsonPropertyName("min_level")]
    [DisplayName("min_level")]
    [Category("レベル")]
    [Description("最低レベル")]
    public int? MinLevel { get; set; }
    #endregion

    #region 最高レベル
    /// <summary>
    /// 最高レベル
    /// </summary>
    [JsonPropertyName("max_level")]
    [DisplayName("max_level")]
    [Category("レベル")]
    [Description("最高レベル")]
    public int? MaxLevel { get; set; }
    #endregion

    #region 遭遇条件値
    /// <summary>
    /// 遭遇条件値
    /// </summary>
    [JsonPropertyName("condition_values")]
    [DisplayName("condition_values")]
    [Category("遭遇")]
    [Description("遭遇条件値")]
    public List<NamedAPIResource>? ConditionValues { get; set; }
    #endregion

    #region 遭遇率
    /// <summary>
    /// 遭遇率
    /// </summary>
    [JsonPropertyName("chance")]
    [DisplayName("chance")]
    [Category("遭遇")]
    [Description("遭遇率")]
    public int? Chance { get; set; }
    #endregion

    #region 遭遇方法
    /// <summary>
    /// 遭遇方法
    /// </summary>
    [JsonPropertyName("method")]
    [DisplayName("method")]
    [Category("遭遇")]
    [Description("遭遇方法")]
    public NamedAPIResource? Method { get; set; }
    #endregion

    #region テキスト
    /// <summary>
    /// テキスト
    /// </summary>
    [Category("(基本)")]
    [Description("概略")]
    public string Text => ToString();
    #endregion


    // メソッド

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        List<string> textList = [];

        textList.Add($"{Method?.Name}");
        textList.Add($"Lv:{MinLevel}～{MaxLevel}");
        textList.Add($"遭遇率:{Chance}");

        return string.Join(" ", textList);
    }
    #endregion
}
