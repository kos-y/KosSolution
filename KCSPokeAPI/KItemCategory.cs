using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテムカテゴリ
/// </summary>
public class KItemCategory
{
    /// <summary>
    /// アイテムカテゴリID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// アイテムカテゴリ名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// アイテムリスト
    /// </summary>
    public List<KNamedAPIResource> Items { get; set; } = [];

    /// <summary>
    /// アイテムカテゴリ名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// ポケット
    /// </summary>
    public KNamedAPIResource Pocket { get; set; } = new KNamedAPIResource();
}
