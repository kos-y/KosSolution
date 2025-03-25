using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 地域
/// </summary>
public class KRegion
{
    /// <summary>
    /// 地域ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 場所リスト
    /// </summary>
    public List<KNamedAPIResource> Locations { get; set; } = [];

    /// <summary>
    /// 地域名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 地域名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// メインの世代
    /// </summary>
    public KNamedAPIResource MainGeneration { get; set; } = new();

    /// <summary>
    /// ポケモン図鑑リスト
    /// </summary>
    public List<KNamedAPIResource> Pokedexes { get; set; } = [];

    /// <summary>
    /// バージョングループリスト
    /// </summary>
    public List<KNamedAPIResource> VersionGroups { get; set; } = [];
}
