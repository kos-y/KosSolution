using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Types;

/// <summary>
/// ポケモンのタイプ
/// </summary>
public class TypePokemon
{
    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    [DisplayName("pokemon")]
    [Category("タイプ")]
    [Description("ポケモン")]
    public NamedAPIResource? Pokemon { get; set; }
    #endregion

    #region スロット
    /// <summary>
    /// スロット
    /// </summary>
    [JsonPropertyName("slot")]
    [DisplayName("slot")]
    [Category("タイプ")]
    [Description("スロット")]
    public int? Slot { get; set; }
    #endregion
}
