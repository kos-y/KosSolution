using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技が影響を与えるステータス
/// </summary>
public class KMoveStatAffect
{
    /// <summary>
    /// 変更量
    /// </summary>
    public int Change { get; set; }

    /// <summary>
    /// 技
    /// </summary>
    public KNamedAPIResource Move { get; set; }
}
