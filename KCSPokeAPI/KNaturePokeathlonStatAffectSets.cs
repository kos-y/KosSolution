using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 性格が影響を与えるポケスロンのステータスセット
/// </summary>
public class KNaturePokeathlonStatAffectSets
{
    /// <summary>
    /// 上昇するステータスリスト
    /// </summary>
    public List<KNaturePokeathlonStatAffect> Increase { get; set; } = [];

    /// <summary>
    /// 下降するステータスリスト
    /// </summary>
    public List<KNaturePokeathlonStatAffect> Decrease { get; set; } = [];
}
