using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 言語
/// </summary>
public class KLanguage
{
    /// <summary>
    /// 言語ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 言語名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 対応言語か
    /// </summary>
    public bool Official { get; set; } = false;

    /// <summary>
    /// ISO639コード
    /// </summary>
    public string ISO639 { get; set; } = string.Empty;

    /// <summary>
    /// ISO3166コード
    /// </summary>
    public string ISO3166 { get; set; } = string.Empty;

    /// <summary>
    /// 名前リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
