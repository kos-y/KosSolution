using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技マシン
/// </summary>
public class KMachine
{
    /// <summary>
    /// 技マシンID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// アイテム
    /// </summary>
    public KNamedAPIResource Item { get; set; }

    /// <summary>
    /// 技
    /// </summary>
    public KNamedAPIResource Move { get; set; }

    /// <summary>
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup { get; set; }
}
