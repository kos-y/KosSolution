using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// バージョングループのフレーバーテキスト
/// </summary>
public class KVersionGroupFlavorText
{
    /// <summary>
    /// テキスト
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// 言語
    /// </summary>
    public KNamedAPIResource Language { get; set; }

    /// <summary>
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup {  get; set; }
}
