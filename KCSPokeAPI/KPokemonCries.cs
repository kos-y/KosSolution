using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンの鳴き声
/// </summary>
public class KPokemonCries
{
    /// <summary>
    /// 最新の鳴き声
    /// </summary>
    public string Latest { get; set; } = string.Empty;

    /// <summary>
    /// 過去の鳴き声
    /// </summary>
    public string Legavy { get; set; } = string.Empty;
}
