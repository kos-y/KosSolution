using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 性格と戦闘スタイルの関係性
/// </summary>
public class KMoveBattleStylePreference
{
    /// <summary>
    /// HPが低い状態でどのぐらい好まれるか
    /// </summary>
    public int LowHPPreference { get; set; }
    
    /// <summary>
    /// HPが高い状態でどのぐらい好まれるか}
    /// </summary>
    public int HighHPPreference { get; set; }

    /// <summary>
    /// 戦闘スタイル
    /// </summary>
    public KNamedAPIResource MoveBattleStyle { get; set; } = new();
}
