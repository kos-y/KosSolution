using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エフェクトの説明
/// </summary>
public class KVerboseEffect
{
    /// <summary>
    /// エフェクトの説明
    /// </summary>
    public string Effect { get; set; } = string.Empty;

    /// <summary>
    /// エフェクトの短い説明
    /// </summary>
    public string ShortEffect { get; set; } = string.Empty;

    /// <summary>
    /// 言語
    /// </summary>
    public KNamedAPIResource Language { get; set; }
}
