using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;
public class KGender
{
    /// <summary>
    /// 性別ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 性別名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    public List<KPokemonSpeciesGender> PokemonSpeciesDetails { get; set; } = [];

    /// <summary>
    /// 性別が要求される進化
    /// </summary>
    public List<KNamedAPIResource> RequiredForEvolution { get; set; } = [];
}
