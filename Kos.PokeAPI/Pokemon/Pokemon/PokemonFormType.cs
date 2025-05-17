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
/// リーフォンフォームのポケモンタイプ
/// </summary>
public class PokemonFormType
{
    #region　タイプ
    /// <summary>
    /// タイプ
    /// </summary>
    [JsonPropertyName("type")]
    [DisplayName("type")]
    [Category("(基本)")]
    [Description("タイプ")]
    public NamedAPIResource? Type { get; set; }
    #endregion

    #region スロット
    /// <summary>
    /// スロット
    /// </summary>
    [JsonPropertyName("slot")]
    [DisplayName("slot")]
    [Category("(基本)")]
    [Description("スロット")]
    public int? Slot { get; set; }
    #endregion
}
