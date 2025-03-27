using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 名前付きAPIリソースリスト
/// </summary>
public class KNamedAPIResourceList
{
    /// <summary>
    /// 件数
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// 次ページへのURL
    /// </summary>
    public string? Next { get; set; } = string.Empty;

    /// <summary>
    /// 前ページへのURL
    /// </summary>
    public string? Previous { get; set; } = string.Empty;

    /// <summary>
    /// 結果リスト
    /// </summary>
    public List<KNamedAPIResource> Results { get; set; } = [];
}
