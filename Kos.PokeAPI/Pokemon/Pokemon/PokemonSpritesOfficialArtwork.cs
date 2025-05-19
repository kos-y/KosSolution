using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - オフィシャルアートワーク
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesOfficialArtwork
{
    #region 正面
    /// <summary>
    /// 正面
    /// </summary>
    [JsonPropertyName("front_default")]
    [DisplayName("front_default")]
    [Category("ポケモン - スプライト - その他 - オフィシャルアートワーク")]
    [Description("正面")]
    public string? FrontDefault { get; set; }
    #endregion

    #region 正面 色違い
    /// <summary>
    /// 正面 色違い
    /// </summary>
    [JsonPropertyName("front_shiny")]
    [DisplayName("front_shiny")]
    [Category("ポケモン - スプライト - その他 - オフィシャルアートワーク")]
    [Description("正面 色違い")]
    public string? FrontShiny { get; set; }
    #endregion
}
