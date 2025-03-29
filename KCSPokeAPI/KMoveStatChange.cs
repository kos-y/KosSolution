using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技が発動した際のステータスへの影響
/// </summary>
public class KMoveStatChange
{
    /// <summary>
    /// 変化量
    /// </summary>
    public int Change { get; set; }

    /// <summary>
    /// 影響を与えるステータス
    /// </summary>
    public KNamedAPIResource Stat { get; set; }
}
