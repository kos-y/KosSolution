using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン種族の性別
/// </summary>
public class KPokemonSpeciesGender
{
    /// <summary>
    /// 確率
    /// </summary>
    public int Rate { get; set; }

    /// <summary>
    /// ポケモン種族
    /// </summary>
    public KNamedAPIResource PokemonSpecies { get; set; } = new();
}
