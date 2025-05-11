using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Abilities;

/// <summary>
/// ポケモンの特性
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class AbilityPokemon
{
    #region 隠れ特性
    /// <summary>
    /// 隠れ特性
    /// </summary>
    [JsonPropertyName("is_hidden")]
    [DisplayName("is_hidden")]
    [Category("(基本)")]
    [Description("隠れ特性")]
    public bool? IsHidden { get; set; }
    #endregion

    #region 特性のスロット
    /// <summary>
    /// 特性のスロット
    /// </summary>
    [JsonPropertyName("slot")]
    [DisplayName("slot")]
    [Category("(基本)")]
    [Description("スロット")]
    public int? Slot { get; set; }
    #endregion

    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    [DisplayName("pokemon")]
    [Category("(基本)")]
    [Description("ポケモン")]
    public NamedAPIResource? Pokemon { get; set; }
    #endregion
}
