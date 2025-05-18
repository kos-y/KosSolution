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
public class PokemonSpritesPattern8
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

    #region 正面 メス
    /// <summary>
    /// 正面 メス
    /// </summary>
    [JsonPropertyName("front_female")]
    [DisplayName("front_female")]
    [Category("ポケモン - スプライト")]
    [Description("正面 メス")]
    public string? FrontFemale { get; set; }
    #endregion

    #region 正面 色違い メス
    /// <summary>
    /// 正面 メス 色違い
    /// </summary>
    [JsonPropertyName("front_shiny_female")]
    [DisplayName("front_shiny_female")]
    [Category("ポケモン - スプライト")]
    [Description("正面 色違い メス")]
    public string? FrontShinyFemale { get; set; }
    #endregion
}
