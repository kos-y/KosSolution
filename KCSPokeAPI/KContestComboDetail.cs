using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンコンテストにおける技のコンボ
/// </summary>
public class KContestComboDetail
{
    /// <summary>
    /// この技の前に使用する技リスト
    /// </summary>
    public List<KNamedAPIResource> UseBeofre { get; set; } = [];

    /// <summary>
    /// この技の後に使用する技リスト
    /// </summary>
    public List<KNamedAPIResource> UseAfter { get; set; } = [];
}
