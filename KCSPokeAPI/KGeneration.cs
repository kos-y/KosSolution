using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 世代
/// </summary>
public class KGeneration
{
    /// <summary>
    /// 世代ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 世代名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 特性リスト
    /// </summary>
    public List<KNamedAPIResource> Abilities { get; set; } = [];

    /// <summary>
    /// 世代名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// メイン地域
    /// </summary>
    public KNamedAPIResource MainRegion { get; set; }

    /// <summary>
    /// 技リスト
    /// </summary>
    public List<KNamedAPIResource> Moves { get; set; } = [];

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    public List<KNamedAPIResource> PokemonSpecies { get; set; } = [];

    /// <summary>
    /// タイプリスト
    /// </summary>
    public List<KNamedAPIResource> Types { get; set; } = [];

    /// <summary>
    /// バージョングループリスト
    /// </summary>
    public List<KNamedAPIResource> VersionGroups { get; set; } = [];
}
