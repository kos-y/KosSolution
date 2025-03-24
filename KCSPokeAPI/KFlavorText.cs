using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// フレーバーテキスト
/// </summary>
public class KFlavorText
{
    /// <summary>
    /// フレーバーテキスト
    /// </summary>
    public string FlavorText { get; set; } = string.Empty;

    /// <summary>
    /// 言語
    /// </summary>
    public KNamedAPIResource Language { get; set; } = new();

    /// <summary>
    /// バージョン
    /// </summary>
    public KNamedAPIResource Version { get; set; } = new();
}
