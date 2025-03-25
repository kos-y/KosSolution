using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 特性に関する効果の変更歴
/// </summary>
public class KAbilityEffectChange
{
    /// <summary>
    /// 効果リスト
    /// </summary>
    public List<KEffect> EffectEntries { get; set; } = [];

    /// <summary>
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup { get; set; } = new();
}
