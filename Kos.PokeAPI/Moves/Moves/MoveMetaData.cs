using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// 技の詳細
/// </summary>
public class MoveMetaData
{
    #region 技のカテゴリ
    /// <summary>
    /// 技のカテゴリ
    /// </summary>
    [JsonPropertyName("category")]
    public NamedAPIResource? Category { get; set; }
    #endregion

    #region 最低攻撃回数
    /// <summary>
    /// 最低攻撃回数
    /// </summary>
    [JsonPropertyName("min_hits")]
    public int? MinHits { get; set; }
    #endregion

    #region 最高攻撃回数
    /// <summary>
    /// 最高攻撃回数
    /// </summary>
    [JsonPropertyName("max_hits")]
    public int? MaxHits { get; set; }
    #endregion

    #region 最低ターン数
    /// <summary>
    /// 最低ターン数
    /// </summary>
    [JsonPropertyName("min_turns")]
    public int? MinTurns { get; set; }
    #endregion

    #region 最高ターン数
    /// <summary>
    /// 最高ターン数
    /// </summary>
    [JsonPropertyName("max_turns")]
    public int? MaxTurns { get; set; }
    #endregion

    #region 急所の当たる確率
    /// <summary>
    /// 急所の当たる確率
    /// </summary>
    [JsonPropertyName("crit_rate")]
    public int? CritRate { get; set; }
    #endregion

    #region 吸収量
    /// <summary>
    /// 吸収量
    /// </summary>
    [JsonPropertyName("drain")]
    public int? Drain { get; set; }
    #endregion

    #region 回復量
    /// <summary>
    /// 回復量
    /// </summary>
    [JsonPropertyName("healing")]
    public int? Healing { get; set; }
    #endregion

    #region 状態異常
    /// <summary>
    /// 状態異常
    /// </summary>
    [JsonPropertyName("ailment")]
    public NamedAPIResource? Ailment { get; set; }
    #endregion

    #region 状態異常になる確率
    /// <summary>
    /// 状態異常になる確率
    /// </summary>
    [JsonPropertyName("ailment_chance")]
    public int? AilmentChance { get; set; }
    #endregion

    #region 相手ガひるむ確率
    /// <summary>
    /// 相手ガひるむ確率
    /// </summary>
    [JsonPropertyName("flinch_change")]
    public int? FlinchChance { get; set; }
    #endregion

    #region ステータスに影響を与える確率
    /// <summary>
    /// ステータスに影響を与える確率
    /// </summary>
    [JsonPropertyName("state_change")]
    public int? StateChance { get; set; }
    #endregion
}
