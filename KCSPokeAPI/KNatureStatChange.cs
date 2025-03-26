using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 性格がポケスロンに影響を与えるステーたる
/// </summary>
public class KNatureStatChange
{
    /// <summary>
    /// 最大変更量
    /// </summary>
    public int MaxChange { get; set; }

    /// <summary>
    /// ポケスロンのステータス
    /// </summary>
    public KNamedAPIResource PokeathlonStat { get; set; } = new();
}
