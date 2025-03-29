using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// パルパークでエンカウントする種族
/// </summary>
public class KPalParkEncounterSpecies
{
    /// <summary>
    /// 基本スコア
    /// </summary>
    public int BaseScore { get; set; }

    /// <summary>
    /// 確率
    /// </summary>
    public int Rage { get; set; }

    /// <summary>
    /// ポケモン種族
    /// </summary>
    public KNamedAPIResource PokemonSpecies { get; set; }
}
