using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// 技の詳細
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class MoveMetaData
{
    #region 技のカテゴリ
    /// <summary>
    /// 技のカテゴリ
    /// </summary>
    [JsonPropertyName("category")]
    [DisplayName("category")]
    [Category("(基本)")]
    [Description("技のカテゴリ")]
    public NamedAPIResource? Category { get; set; }
    #endregion

    #region 最低攻撃回数
    /// <summary>
    /// 最低攻撃回数
    /// </summary>
    [JsonPropertyName("min_hits")]
    [DisplayName("min_hits")]
    [Category("攻撃回数")]
    [Description("最低攻撃回数")]
    public int? MinHits { get; set; }
    #endregion

    #region 最高攻撃回数
    /// <summary>
    /// 最高攻撃回数
    /// </summary>
    [JsonPropertyName("max_hits")]
    [DisplayName("max_hits")]
    [Category("攻撃回数")]
    [Description("最高攻撃回数")]
    public int? MaxHits { get; set; }
    #endregion

    #region 最低ターン数
    /// <summary>
    /// 最低ターン数
    /// </summary>
    [JsonPropertyName("min_turns")]
    [DisplayName("min_turns")]
    [Category("ターン数")]
    [Description("最低ターン数")]
    public int? MinTurns { get; set; }
    #endregion

    #region 最高ターン数
    /// <summary>
    /// 最高ターン数
    /// </summary>
    [JsonPropertyName("max_turns")]
    [DisplayName("max_turns")]
    [Category("ターン数")]
    [Description("最高ターン数")]
    public int? MaxTurns { get; set; }
    #endregion

    #region 急所の当たる確率
    /// <summary>
    /// 急所の当たる確率
    /// </summary>
    [JsonPropertyName("crit_rate")]
    [DisplayName("crit_rate")]
    [Category("(基本)")]
    [Description("急所の当たる確率")]
    public int? CritRate { get; set; }
    #endregion

    #region 吸収量
    /// <summary>
    /// 吸収量
    /// </summary>
    [JsonPropertyName("drain")]
    [DisplayName("drain")]
    [Category("(基本)")]
    [Description("吸収量")]
    public int? Drain { get; set; }
    #endregion

    #region 回復量
    /// <summary>
    /// 回復量
    /// </summary>
    [JsonPropertyName("healing")]
    [DisplayName("healing")]
    [Category("(基本)")]
    [Description("回復量")]
    public int? Healing { get; set; }
    #endregion

    #region 状態異常
    /// <summary>
    /// 状態異常
    /// </summary>
    [JsonPropertyName("ailment")]
    [DisplayName("ailment")]
    [Category("状態異常")]
    [Description("状態異常")]
    public NamedAPIResource? Ailment { get; set; }
    #endregion

    #region 状態異常になる確率
    /// <summary>
    /// 状態異常になる確率
    /// </summary>
    [JsonPropertyName("ailment_chance")]
    [DisplayName("ailment_chance")]
    [Category("状態異常")]
    [Description("状態異常になる確率")]
    public int? AilmentChance { get; set; }
    #endregion

    #region 相手ガひるむ確率
    /// <summary>
    /// 相手ガひるむ確率
    /// </summary>
    [JsonPropertyName("flinch_change")]
    [DisplayName("flinch_change")]
    [Category("(基本)")]
    [Description("相手ガひるむ確率")]
    public int? FlinchChance { get; set; }
    #endregion

    #region ステータスに影響を与える確率
    /// <summary>
    /// ステータスに影響を与える確率
    /// </summary>
    [JsonPropertyName("state_change")]
    [DisplayName("state_change")]
    [Category("(基本)")]
    [Description("ステータスに影響を与える確率")]
    public int? StateChance { get; set; }
    #endregion
}
