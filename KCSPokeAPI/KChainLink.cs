using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 進化チェーンのリンク
/// </summary>
public class KChainLink
{
    /// <summary>
    /// ベビーポケモンか
    /// </summary>
    public bool IsBaby { get; set; }

    /// <summary>
    /// 種族
    /// </summary>
    public KNamedAPIResource Species { get; set; }

    /// <summary>
    /// 進化条件詳細リスト
    /// </summary>
    public List<KEvolutionDetail> EvolutionDetails { get; set; } = [];

    /// <summary>
    /// 進化先リスト
    /// </summary>
    public List<KChainLink> EvolvesTo { get; set; } = [];
}
