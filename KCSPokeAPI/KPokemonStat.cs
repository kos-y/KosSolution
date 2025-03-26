using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンステータス
/// </summary>
public class KPokemonStat
{
    /// <summary>
    /// ステータス
    /// </summary>
    public KNamedAPIResource Stat { get; set; } = new();

    /// <summary>
    /// 努力値
    /// </summary>
    public int Effort { get; set; }

    /// <summary>
    /// 種族値
    /// </summary>
    public int BaseStat { get; set; }
}
