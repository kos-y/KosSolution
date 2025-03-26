using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技の対象
/// </summary>
public class KMoveTarget
{
    /// <summary>
    /// 技の対象ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 技の対象名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 説明リスト
    /// </summary>
    public List<KDescription> Descriptions { get; set; } = [];

    /// <summary>
    /// 技リスト
    /// </summary>
    public List<KNamedAPIResource> Moves { get; set; } = [];

    /// <summary>
    /// 技の対象名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
