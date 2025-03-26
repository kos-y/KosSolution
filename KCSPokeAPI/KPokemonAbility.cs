using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンの特性
/// </summary>
public class KPokemonAbility
{
    /// <summary>
    /// 隠れ特性
    /// </summary>
    public bool IsHidden { get; set; }

    /// <summary>
    /// 何番目
    /// </summary>
    public int Slot { get; set; }

    /// <summary>
    /// 特性
    /// </summary>
    public KNamedAPIResource Ability { get; set; } = new();
}
