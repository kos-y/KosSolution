using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 生息地
/// </summary>
public class KPokemonHabitat
{
    /// <summary>
    /// ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 名前リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    public List<KNamedAPIResource> PokemonSpecies { get; set; } = [];
}
