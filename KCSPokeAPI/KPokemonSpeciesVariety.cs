using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン種族のバリエーション
/// </summary>
public class KPokemonSpeciesVariety
{
    /// <summary>
    /// デフォルトか
    /// </summary>
    public bool IsDefault { get; set; }

    /// <summary>
    /// ポケモン
    /// </summary>
    public KNamedAPIResource Pokemon { get; set; } = new();
}
