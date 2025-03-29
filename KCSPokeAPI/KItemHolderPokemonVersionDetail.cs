using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン所持アイテム詳細
/// </summary>
public class KItemHolderPokemonVersionDetail
{
    /// <summary>
    /// 所持確率
    /// </summary>
    public int Rarity { get; set; }

    /// <summary>
    /// バージョン
    /// </summary>
    public KNamedAPIResource Version { get; set; }
}
