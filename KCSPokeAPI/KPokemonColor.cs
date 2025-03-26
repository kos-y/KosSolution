using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンの色
/// </summary>
public class KPokemonColor
{
    /// <summary>
    /// 色ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 色名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 色名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    public List<KNamedAPIResource> PokemonSpecies { get; set; } = [];
}
