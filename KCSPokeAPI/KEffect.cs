using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エフェクト
/// </summary>
public class KEffect
{
    /// <summary>
    /// 絵ジェクト
    /// </summary>
    public string Effect { get; set; } = string.Empty;

    /// <summary>
    /// 言語
    /// </summary>
    public KNamedAPIResource Language { get; set; }
}
