using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// 過去のポケモン特性
/// </summary>
public class PokemonAbilityPast
{
    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    [DisplayName("generation")]
    [Category("(基本)")]
    [Description("世代")]
    public NamedAPIResource? Generation { get; set; }
    #endregion

    #region 特性リスト
    /// <summary>
    /// 特性リスト
    /// </summary>
    [JsonPropertyName("abilities")]
    [DisplayName("abilities")]
    [Category("(基本)")]
    [Description("特性リスト")]
    public IReadOnlyList<PokemonAbility>? Abilities { get; set; }
    #endregion
}
