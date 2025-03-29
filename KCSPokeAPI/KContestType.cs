using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// コンテストの部門
/// </summary>
public class KContestType
{
    /// <summary>
    /// コンテストの部門ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// コンテストの部門名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// きのみの味
    /// </summary>
    public KNamedAPIResource BerryFlavor { get; set; }

    /// <summary>
    /// コンテストの部門名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
