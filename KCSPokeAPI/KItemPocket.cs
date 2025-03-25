using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテムポケット
/// </summary>
public class KItemPocket
{
    /// <summary>
    /// アイテムポケットID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// アイテムポケット名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// カテゴリリスト
    /// </summary>
    public List<KNamedAPIResource> Categories { get; set; } = [];

    /// <summary>
    /// アイテムポケット名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
} 
