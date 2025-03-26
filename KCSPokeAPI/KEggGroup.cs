using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 卵グループ
/// </summary>
public class KEggGroup
{
    /// <summary>
    /// 卵グループID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 卵グループ名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 卵グループ名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    public List<KNamedAPIResource> PokemonSpecies { get; set; } = [];
}
