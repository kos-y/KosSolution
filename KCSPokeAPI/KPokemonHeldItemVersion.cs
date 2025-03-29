using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// バージョンごとのポケモンがもっているアイテム
/// </summary>
public class KPokemonHeldItemVersion
{
    /// <summary>
    /// バージョン
    /// </summary>
    public KNamedAPIResource Version { get; set; }

    /// <summary>
    /// 確率
    /// </summary>
    public int Rarity { get; set; }
}
