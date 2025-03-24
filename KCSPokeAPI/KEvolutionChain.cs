using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 進化チェーン
/// </summary>
public class KEvolutionChain
{
    /// <summary>
    /// 進化チェーンID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// ベビーポケモンが進化するアイテム
    /// </summary>
    public KNamedAPIResource BabyTriggerItem { get; set; } = new();

    /// <summary>
    /// チェーン
    /// </summary>
    public KChainLink Chain { get; set; } = new();
}
