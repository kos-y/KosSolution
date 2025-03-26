using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 過去のポケモンタイプ
/// </summary>
public class KPokemonTypePast
{
    /// <summary>
    /// 世代
    /// </summary>
    public KNamedAPIResource Generation { get; set; } = new();

    /// <summary>
    /// タイプリスト
    /// </summary>
    public List<KPokemonType> Types { get; set; } = [];
}
