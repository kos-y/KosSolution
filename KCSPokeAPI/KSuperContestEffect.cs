using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// スーパーコンテストの効果
/// </summary>
public class KSuperContestEffect
{
    /// <summary>
    /// スーパーコンテストの効果ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// アピールポイント
    /// </summary>
    public int Appeal { get; set; }

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    public List<KFlavorText> FlavorTextEntries { get; set; } = [];

    /// <summary>
    /// 技リスト
    /// </summary>
    public List<KNamedAPIResource> Moves { get; set; } = [];
}
