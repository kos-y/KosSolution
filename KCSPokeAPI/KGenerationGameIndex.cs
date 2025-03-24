using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ゲームインデックスごとの世代
/// </summary>
public class KGenerationGameIndex
{
    /// <summary>
    /// ゲームインデックス
    /// </summary>
    public int GameIndex { get; set; }

    /// <summary>
    /// 世代
    /// </summary>
    public KNamedAPIResource Generation { get; set; } = new();
}
