using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 状態異常
/// </summary>
public class KMoveAilment
{
    /// <summary>
    /// 状態異常ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 状態異常名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 状態異常が発動する技リスト
    /// </summary>
    public List<KNamedAPIResource> Moves { get; set; } = [];

    /// <summary>
    /// 状態異常名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
