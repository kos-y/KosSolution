using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンタイプ
/// </summary>
public class KPokemonType
{
    /// <summary>
    /// 何番目か
    /// </summary>
    public int Slot { get; set; }

    /// <summary>
    /// タイプ
    /// </summary>
    public KNamedAPIResource Type { get; set; }
}
