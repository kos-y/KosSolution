using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// コンテストの効果
/// </summary>
public class KContestEffect
{
    /// <summary>
    /// コンテストの効果ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// アピールポイント
    /// </summary>
    public int Appeal { get; set; }

    /// <summary>
    /// 妨害ポイント
    /// </summary>
    public int Jam { get; set; }

    /// <summary>
    /// 効果リスト
    /// </summary>
    public List<KEffect> EffectEntries { get; set; } = [];

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    public List<KFlavorText> FlavorTextEntries { get; set; } = [];
}
