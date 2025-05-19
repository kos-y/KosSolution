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
/// ポケモンの特性
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonAbility
{
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

    #region 特性
    /// <summary>
    /// 特性
    /// </summary>
    [JsonPropertyName("ability")]
    [DisplayName("ability")]
    [Category("(基本)")]
    [Description("特性")]
    public NamedAPIResource? Ability { get; set; }
    #endregion

    #region 隠し特性
    /// <summary>
    /// 隠し特性
    /// </summary>
    [JsonPropertyName("is_hidden")]
    [DisplayName("is_hidden")]
    [Category("(基本)")]
    [Description("隠し特性")]
    public bool? IsHidden { get; set; }
    #endregion
}
