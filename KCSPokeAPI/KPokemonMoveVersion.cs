using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン 技バージョン
/// </summary>
public class KPokemonMoveVersion
{
    /// <summary>
    /// 技の習得方法
    /// </summary>
    public KNamedAPIResource MoveLearnMethod { get; set; } = new();

    /// <summary>
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup { get; set; } = new();

    /// <summary>
    /// 習得最低レベル
    /// </summary>
    public int LevelLearnedAt { get; set; }
}
