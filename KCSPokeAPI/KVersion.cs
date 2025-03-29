using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// バージョン
/// </summary>
public class KVersion
{
    /// <summary>
    /// バージョンID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// バージョン名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// バージョン名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup { get; set; }
}
