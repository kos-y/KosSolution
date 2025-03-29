using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン種族のポケモン図鑑エントリー
/// </summary>
public class KPokemonSpeciesDexEntry
{
    /// <summary>
    /// 図鑑番号
    /// </summary>
    public int EntryNumber { get; set; }

    /// <summary>
    /// ポケモン図鑑
    /// </summary>
    public KNamedAPIResource Pokedex { get; set; }
}
