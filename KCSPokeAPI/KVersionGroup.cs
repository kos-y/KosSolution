using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// バージョングループ
/// </summary>
public class KVersionGroup
{
    /// <summary>
    /// バージョングループID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// バージョングループ名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 順番
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// 世代
    /// </summary>
    public KNamedAPIResource Generation { get; set; } = new();

    /// <summary>
    /// 技の習得方法リスト
    /// </summary>
    public List<KNamedAPIResource> MoveLearnMethods { get; set; } = [];

    /// <summary>
    /// ポケモン図鑑リスト
    /// </summary>
    public List<KNamedAPIResource> Pokedexes { get; set; } = [];

    /// <summary>
    /// 地域リスト
    /// </summary>
    public List<KNamedAPIResource> Regions { get; set; } = [];

    /// <summary>
    /// バージョンリスト
    /// </summary>
    public List<KNamedAPIResource> Version { get; set; } = [];
}
