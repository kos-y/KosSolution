using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 性格がステータスに与える影響
/// </summary>
public class KNatureStatAffectSets
{
    /// <summary>
    /// いい影響を与えるステータスリスト
    /// </summary>
    public List<KNamedAPIResource> Increase { get; set; } = [];

    /// <summary>
    /// 悪い影響を与えるステータスリスト
    /// </summary>
    public List<KNamedAPIResource> Decrease { get; set; } = [];
}
