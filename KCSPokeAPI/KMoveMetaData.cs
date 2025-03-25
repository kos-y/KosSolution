using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技のメタデータ
/// </summary>
public class KMoveMetaData
{
    /// <summary>
    /// 状態異常
    /// </summary>
    public KNamedAPIResource Ailment { get; set; } = new();

    /// <summary>
    /// 技のカテゴリ
    /// </summary>
    public KNamedAPIResource Category { get; set; } = new();

    /// <summary>
    /// 最低攻撃回数
    /// </summary>
    public int MinHits { get; set; }

    /// <summary>
    /// 最高攻撃回数
    /// </summary>
    public int MaxHis { get; set; }

    /// <summary>
    /// 最低ターン数
    /// </summary>
    public int MinTurns { get; set; }

    /// <summary>
    /// 最高ターン数
    /// </summary>
    public int MaxTurns { get; set; }

    /// <summary>
    /// 吸収量
    /// </summary>
    public int Drain { get; set; }

    /// <summary>
    /// 回復量
    /// </summary>
    public int Healing { get; set; }

    /// <summary>
    /// 急所の当たる確率
    /// </summary>
    public int CritCate { get; set; }

    /// <summary>
    /// 状態異常になる確率
    /// </summary>
    public int AilmentChance { get; set; }

    /// <summary>
    /// 相手ガひるむ確率
    /// </summary>
    public int FlinchChance { get; set; }

    /// <summary>
    /// ステータスに影響を与える確率
    /// </summary>
    public int StateChance { get; set; }
}
