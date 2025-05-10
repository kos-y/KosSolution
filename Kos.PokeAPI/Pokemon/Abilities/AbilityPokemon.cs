using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Abilities;

/// <summary>
/// ポケモンの特性
/// </summary>
public class AbilityPokemon
{
    #region 隠れ特性
    /// <summary>
    /// 隠れ特性
    /// </summary>
    public bool? IsHidden { get; set; }
    #endregion

    #region 特性のスロット
    /// <summary>
    /// 特性のスロット
    /// </summary>
    public int? Slot { get; set; }
    #endregion

    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    public NamedAPIResource? Pokemon { get; set; }
    #endregion
}
