using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技が影響を与えるステータス
/// </summary>
public class KMoveStatAffectSets
{
    /// <summary>
    /// いい影響を与えるステータス
    /// </summary>
    public List<KMoveStatAffect> Increase { get; set; } = [];

    /// <summary>
    /// 悪い影響を与えるステータス
    /// </summary>
    public List<KMoveStatAffect> Decrease { get; set; } = [];
}
