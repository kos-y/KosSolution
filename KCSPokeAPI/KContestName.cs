using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// コンテスト名
/// </summary>
public class KContestName
{
    /// <summary>
    /// コンテスト名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 色
    /// </summary>
    public int Color { get; set; }

    /// <summary>
    /// 言語
    /// </summary>
    public KNamedAPIResource Language { get; set; } = new();
}
