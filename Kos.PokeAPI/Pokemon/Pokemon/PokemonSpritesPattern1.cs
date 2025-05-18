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
public class PokemonSpritesPattern1
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

    #region 正面 モノクロ
    /// <summary>
    /// 正面 モノクロ
    /// </summary>
    [JsonPropertyName("front_default")]
    [DisplayName("front_default")]
    [Category("ポケモン - スプライト")]
    [Description("正面 モノクロ")]
    public string? FrontGray { get; set; }
    #endregion

    #region 正面 透過
    /// <summary>
    /// 正面 透過
    /// </summary>
    [JsonPropertyName("front_default")]
    [DisplayName("front_default")]
    [Category("ポケモン - スプライト")]
    [Description("正面 透過")]
    public string? FrontTransparent { get; set; }
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

    #region 背面 モノクロ
    /// <summary>
    /// 背面 モノクロ
    /// </summary>
    [JsonPropertyName("back_default")]
    [DisplayName("back_default")]
    [Category("ポケモン - スプライト")]
    [Description("背面 モノクロ")]
    public string? BackGray { get; set; }
    #endregion

    #region 背面 透過
    /// <summary>
    /// 背面 透過
    /// </summary>
    [JsonPropertyName("back_default")]
    [DisplayName("back_default")]
    [Category("ポケモン - スプライト")]
    [Description("背面 透過")]
    public string? BackTransparent { get; set; }
    #endregion
}
