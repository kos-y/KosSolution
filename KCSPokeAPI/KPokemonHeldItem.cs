using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンがもっているアイテム
/// </summary>
public class KPokemonHeldItem
{
    /// <summary>
    /// アイテム
    /// </summary>
    public KNamedAPIResource Item { get; set; } = new();

    /// <summary>
    /// バージョンごとの詳細情報
    /// </summary>
    public List<KPokemonHeldItemVersion> VersionDetails { get; set; } = [];
}
