using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン リージョンフォーム スプライト
/// </summary>
public class KPokemonFormSprites
{
    /// <summary>
    /// 正面
    /// </summary>
    public string FrontDefault { get; set; } = string.Empty;

    /// <summary>
    /// 正面 色違い
    /// </summary>
    public string FrontShiny { get; set; } = string.Empty;

    /// <summary>
    /// 背面
    /// </summary>
    public string BackDefault { get; set; } = string.Empty;

    /// <summary>
    /// 背面 色違い
    /// </summary>
    public string BackShiny { get; set; } = string.Empty;
}
