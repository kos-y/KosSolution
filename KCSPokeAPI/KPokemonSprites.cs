using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモンスプライト
/// </summary>
public class KPokemonSprites
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
    /// 正面 メス
    /// </summary>
    public string FrontFemale { get; set; } = string.Empty;

    /// <summary>
    /// 正面 メス 色違い
    /// </summary>
    public string FrontShinyFemale { get; set; } = string.Empty;

    /// <summary>
    /// 背面
    /// </summary>
    public string BackDefault { get; set; } = string.Empty;

    /// <summary>
    /// 背面 色違い
    /// </summary>
    public string BackShiny { get; set; } = string.Empty;

    /// <summary>
    /// 背面 メス
    /// </summary>
    public string BackFemale { get; set; } = string.Empty;

    /// <summary>
    /// 背面 メス 色違い
    /// </summary>
    public string BackShinyFemale { get; set; } = string.Empty;
}
