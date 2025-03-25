using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンコンテストにおける技のコンボセット
/// </summary>
public class KContestComboSets
{
    /// <summary>
    /// 通常のコンテスト
    /// </summary>
    public KContestComboDetail Normal { get; set; } = new();

    /// <summary>
    /// スーパーコンテスト
    /// </summary>
    public KContestComboDetail Super { get; set; } = new();
}
