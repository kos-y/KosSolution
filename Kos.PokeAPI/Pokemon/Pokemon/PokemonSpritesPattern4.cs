using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesPattern4
{
    #region 正面
    /// <summary>
    /// 正面
    /// </summary>
    [JsonPropertyName("front_default")]
    [DisplayName("front_default")]
    [Category("ポケモン - スプライト")]
    [Description("正面")]
    public string? FrontDefault { get; set; }
    #endregion

    #region 正面 色違い
    /// <summary>
    /// 正面 色違い
    /// </summary>
    [JsonPropertyName("front_shiny")]
    [DisplayName("front_shiny")]
    [Category("ポケモン - スプライト")]
    [Description("正面 色違い")]
    public string? FrontShiny { get; set; }
    #endregion

    #region 背面
    /// <summary>
    /// 背面
    /// </summary>
    [JsonPropertyName("back_default")]
    [DisplayName("back_default")]
    [Category("ポケモン - スプライト")]
    [Description("背面")]
    public string? BackDefault { get; set; }
    #endregion

    #region 背面 色違い
    /// <summary>
    /// 背面 色違い
    /// </summary>
    [JsonPropertyName("back_shiny")]
    [DisplayName("back_shiny")]
    [Category("ポケモン - スプライト")]
    [Description("背面 色違い")]
    public string? BackShiny { get; set; }
    #endregion
}
