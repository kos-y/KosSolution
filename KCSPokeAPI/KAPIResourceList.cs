using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// APIリソースリスト
/// </summary>
public class KAPIResourceList
{
    /// <summary>
    /// 件数
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// 次ページへのURL
    /// </summary>
    public string Next { get; set; } = string.Empty;

    /// <summary>
    /// 前ページへのURL
    /// </summary>
    public string Previous { get; set; } = string.Empty;

    /// <summary>
    /// 結果リスト
    /// </summary>
    public List<KAPIResource> Results { get; set; } = [];
}
