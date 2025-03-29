using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ゲームインデックスのバージョン
/// </summary>
public class KVersionGameIndex
{
    /// <summary>
    /// ゲームインデックス
    /// </summary>
    public int GameIndex { get; set; }

    /// <summary>
    /// バージョン
    /// </summary>
    public KNamedAPIResource Version { get; set; }

}
