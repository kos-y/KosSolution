using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンタイプ
/// </summary>
public class KTypePokemon
{
    /// <summary>
    /// スロット
    /// </summary>
    public int Slot { get; set; }

    /// <summary>
    /// ポケモン
    /// </summary>
    public KNamedAPIResource Pokemon { get; set; }
}
