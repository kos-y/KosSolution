using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// パルパークエリア
/// </summary>
public class KPalParkArea
{
    /// <summary>
    /// パルパークエリアID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// パルパークエリア名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// パルパークエリア名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// エンカウントするポケモン種族リスト
    /// </summary>
    public List<KPalParkEncounterSpecies> PokemonEncounters { get; set; } = [];
}
