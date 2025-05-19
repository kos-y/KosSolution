using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - 第2世代
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesGeneration2
{
    #region 金
    /// <summary>
    /// 金
    /// </summary>
    [JsonPropertyName("gold")]
    [DisplayName("gold")]
    [Category("ポケモン - スプライト")]
    [Description("金")]
    public PokemonSpritesPattern2? Gold { get; set; }
    #endregion

    #region 銀
    /// <summary>
    /// 銀
    /// </summary>
    [JsonPropertyName("silver")]
    [DisplayName("silver")]
    [Category("ポケモン - スプライト")]
    [Description("銀")]
    public PokemonSpritesPattern2? Silver { get; set;}
    #endregion

    #region クリスタル
    /// <summary>
    /// クリスタル
    /// </summary>
    [JsonPropertyName("crystal")]
    [DisplayName("crystal")]
    [Category("ポケモン - スプライト")]
    [Description("クリスタル")]
    public PokemonSpritesPattern3? Crystal { get; set; }
    #endregion
}
