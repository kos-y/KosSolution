using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// きのみの味
/// </summary>
public class KBerryFlavor
{
    /// <summary>
    /// きのみの味ID
    /// </summary>
    public int ID {  get; set; }

    /// <summary>
    /// きのみの味名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// きのみリスト
    /// </summary>
    public List<KFlavorBerryMap> Berries { get; set; } = [];

    /// <summary>
    /// ポケモンコンテストの部門
    /// </summary>
    public KNamedAPIResource ContestType { get; set; } = new();

    /// <summary>
    /// きのみの味名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
