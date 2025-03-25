using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技がもつ過去のステータス値
/// </summary>
public class KPastMoveStatValues
{
    /// <summary>
    /// 命中率
    /// </summary>
    public int Accuracy { get; set; }

    /// <summary>
    /// 効果が発生する確率
    /// </summary>
    public int EffectChance { get; set; }

    /// <summary>
    /// 威力
    /// </summary>
    public int Power { get; set; }

    /// <summary>
    /// 消費PP
    /// </summary>
    public int PP { get; set; }

    /// <summary>
    /// 効果リスト
    /// </summary>
    public List<KVerboseEffect> EffectEntries { get; set; } = [];

    /// <summary>
    /// 技タイプ
    /// </summary>
    public KNamedAPIResource Type { get; set; } = new();

    /// <summary>
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup { get; set; } = new();
}
