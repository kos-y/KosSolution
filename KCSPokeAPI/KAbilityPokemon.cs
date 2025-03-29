using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン特性
/// </summary>
public class KAbilityPokemon
{
    /// <summary>
    /// 隠れ特性
    /// </summary>
    public bool IsHidden { get; set; }

    /// <summary>
    /// 特性の位置
    /// </summary>
    public int Slot { get; set; }

    /// <summary>
    /// ポケモン
    /// </summary>
    public KNamedAPIResource Pokemon { get; set; }
}
