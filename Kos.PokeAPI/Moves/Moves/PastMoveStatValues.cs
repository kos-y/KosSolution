using System.ComponentModel;
using System.Text.Json.Serialization;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// 技がもつ過去のステータス値
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PastMoveStatValues
{
    #region 命中率
    /// <summary>
    /// 命中率
    /// </summary>
    [JsonPropertyName("accuracy")]
    [DisplayName("accuracy")]
    [Category("(基本)")]
    [Description("命中率")]
    public int? Accuracy { get; set; }
    #endregion

    #region 効果が発生する確率
    /// <summary>
    /// 効果が発生する確率
    /// </summary>
    [JsonPropertyName("effect_chance")]
    [DisplayName("effect_chance")]
    [Category("(基本)")]
    [Description("効果が発生する確率")]
    public int? EffectChance { get; set; }
    #endregion

    #region 威力
    /// <summary>
    /// 威力
    /// </summary>
    [JsonPropertyName("power")]
    [DisplayName("power")]
    [Category("(基本)")]
    [Description("威力")]
    public int? Power { get; set; }
    #endregion

    #region 消費PP
    /// <summary>
    /// 消費PP
    /// </summary>
    [JsonPropertyName("pp")]
    [DisplayName("pp")]
    [Category("(基本)")]
    [Description("消費PP")]
    public int? PP { get; set; }
    #endregion

    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [DisplayName("effect_entries")]
    [Category("(基本)")]
    [Description("効果リスト")]
    [TypeConverter(typeof(ListConverter<VerboseEffect>))]
    public List<VerboseEffect>? EffectEntries { get; set; }
    #endregion

    #region 技タイプ
    /// <summary>
    /// 技タイプ
    /// </summary>
    [JsonPropertyName("type")]
    [DisplayName("type")]
    [Category("(基本)")]
    [Description("技タイプ")]
    public NamedAPIResource? Type { get; set; }
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

    #region 概略
    /// <summary>
    /// 概略
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

        if (VersionGroup?.Name is not null) {
            textList.Add(VersionGroup.Name);
        }

        if (Type?.Name is not null) {
            textList.Add(Type.Name);
        }

        if (Power is not null) {
            textList.Add($"威力:{Power}");
        }

        if (PP is not null) {
            textList.Add($"PP:{PP}");
        }

        return string.Join(" ", textList);
    }
    #endregion
}
