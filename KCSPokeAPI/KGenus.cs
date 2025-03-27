using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 図鑑で表示される「〇〇ポケモン」
/// </summary>
public class KGenus
{
    /// <summary>
    /// 〇〇ポケモン
    /// </summary>
    public string Genus { get; set; } = string.Empty;

    /// <summary>
    /// 言語
    /// </summary>
    public KNamedAPIResource Language { get; set; } = new();
}
