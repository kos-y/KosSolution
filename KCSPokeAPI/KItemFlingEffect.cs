using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテムを投げつけた時の効果
/// </summary>
public class KItemFlingEffect
{
    /// <summary>
    /// 効果ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 効果名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 効果リスト
    /// </summary>
    public List<KEffect> EffectEntries { get; set; } = [];

    /// <summary>
    /// アイテムリスト
    /// </summary>
    public List<KNamedAPIResource> Items { get; set; } = [];
}
