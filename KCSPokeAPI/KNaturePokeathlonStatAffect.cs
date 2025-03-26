using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 性格が影響を与えるポケスロンのステータス
/// </summary>
public class KNaturePokeathlonStatAffect
{
    /// <summary>
    /// 最大の変更料
    /// </summary>
    public int MaxChange { get; set; }

    /// <summary>
    /// 性格
    /// </summary>
    public KNamedAPIResource Nature { get; set; } = new();
}
