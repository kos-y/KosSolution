using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテム特性
/// </summary>
public class KItemAttribute
{
    /// <summary>
    /// アイテム特性ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// アイテム特性名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// アイテムリスト
    /// </summary>
    public List<KNamedAPIResource> Items { get; set; } = [];

    /// <summary>
    /// アイテム特性リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    public List<KDescription> Descriptions { get; set; } = [];
}
