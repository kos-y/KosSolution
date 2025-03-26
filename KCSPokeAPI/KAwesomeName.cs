using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 愛称
/// </summary>
public class KAwesomeName
{
    /// <summary>
    /// 愛称
    /// </summary>
    public string AwesomeName { get; set; } = string.Empty;

    /// <summary>
    /// 言語
    /// </summary>
    public KNamedAPIResource Language { get; set; } = new();
}
