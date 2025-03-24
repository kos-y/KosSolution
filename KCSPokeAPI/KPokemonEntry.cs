using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン登録情報
/// </summary>
public class KPokemonEntry
{
    /// <summary>
    /// ポケモン図鑑No.
    /// </summary>
    public int EntryNumber { get; set; }

    /// <summary>
    /// ポケモン種族
    /// </summary>
    public KNamedAPIResource PokemonSpecies { get; set; } = new();
}
