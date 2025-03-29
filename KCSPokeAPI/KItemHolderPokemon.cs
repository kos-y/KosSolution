using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン所持アイテム
/// </summary>
public class KItemHolderPokemon
{
    /// <summary>
    /// ポケモン
    /// </summary>
    public KNamedAPIResource Pokemon { get; set; }

    /// <summary>
    /// 詳細リスト
    /// </summary>
    public List<KItemHolderPokemonVersionDetail> VersionDetails { get; set; } = [];
}
