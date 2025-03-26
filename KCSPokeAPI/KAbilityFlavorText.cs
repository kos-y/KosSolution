using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 特性フレーバーテキスト
/// </summary>
public class KAbilityFlavorText
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
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup { get; set; } = new();
}
