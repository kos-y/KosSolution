using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技の戦闘スタイル
/// </summary>
public class KMoveBattleStyle
{
    /// <summary>
    /// 技の戦闘スタイルID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 技の戦闘スタイル名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 技の戦闘スタイル名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
