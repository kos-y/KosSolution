using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 説明
/// </summary>
public class KDescription
{
    /// <summary>
    /// 説明
    /// </summary>
    public string Descriptin { get; set; } = string.Empty;

    /// <summary>
    /// 言語
    /// </summary>
    public KNamedAPIResource Language { get; set; }
}
