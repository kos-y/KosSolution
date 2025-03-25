using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技の習得方法
/// </summary>
public class KMoveLearnMethod
{
    /// <summary>
    /// 技の習得方法ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 技の習得方法名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 説明リスト
    /// </summary>
    public List<KDescription> Descriptions { get; set; } = [];

    /// <summary>
    /// 技の習得方法名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// バージョングループリスト
    /// </summary>
    public List<KNamedAPIResource> VersionGroups { get; set; } = [];
}
