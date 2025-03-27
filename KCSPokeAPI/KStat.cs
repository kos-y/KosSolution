using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ステータス
/// </summary>
public class KStat
{
    /// <summary>
    /// ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// ゲームIndex
    /// </summary>
    public int GameIndex { get; set; }

    /// <summary>
    /// 戦闘時のみか
    /// </summary>
    public bool IsBattleOnly { get; set; }

    /// <summary>
    /// 影響を与える技
    /// </summary>
    public KMoveStatAffectSets AffectingMoves { get; set; } = new();

    /// <summary>
    /// 影響を与える性格
    /// </summary>
    public KNaturePokeathlonStatAffectSets AffectingNatures { get; set; } = new();

    /// <summary>
    /// 個性リスト
    /// </summary>
    public List<KNamedAPIResource> Characteristics { get; set; } = [];

    /// <summary>
    /// 技のダメージ分類
    /// </summary>
    public KNamedAPIResource MoveDamageClass { get; set; } = new();

    /// <summary>
    /// 名前リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
