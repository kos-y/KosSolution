using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンの技
/// </summary>
public class KPokemonMove
{
    /// <summary>
    /// 技
    /// </summary>
    public KNamedAPIResource Move { get; set; } = new();

    /// <summary>
    /// バージョンごとの詳細
    /// </summary>
    public List<KPokemonMoveVersion> VersionGroupDetails { get; set; } = [];
}
