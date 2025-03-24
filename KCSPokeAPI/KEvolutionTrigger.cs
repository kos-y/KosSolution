using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 進化トリガー
/// </summary>
public class KEvolutionTrigger
{
    /// <summary>
    /// 進化トリガーID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 進化トリガー名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 進化トリガー名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    public List<KNamedAPIResource> PokemonSpecies { get; set; } = [];
}
