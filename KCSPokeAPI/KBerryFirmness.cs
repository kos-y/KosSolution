using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// きのみの固さ
/// </summary>
public class KBerryFirmness
{
    /// <summary>
    /// きのみの固さID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// きのみの固さ名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// きのみリスト
    /// </summary>
    public List<KNamedAPIResource> Berries { get; set; } = [];

    /// <summary>
    /// きのみの固さ名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
