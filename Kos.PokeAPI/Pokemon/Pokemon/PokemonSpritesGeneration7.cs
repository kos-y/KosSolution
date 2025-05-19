using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - 第7世代
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesGeneration7
{
    #region アイコン
    /// <summary>
    /// アイコン
    /// </summary>
    [JsonPropertyName("icons")]
    [DisplayName("icons")]
    [Category("ポケモン - スプライト")]
    [Description("アイコン")]
    public PokemonSpritesIcons? Icons { get; set; }
    #endregion

    #region ウルトラサン・ウルトラムーン
    /// <summary>
    /// ウルトラサン・ウルトラムーン
    /// </summary>
    [JsonPropertyName("ultra-sun-ultra-moon")]
    [DisplayName("ultra-sun-ultra-moon")]
    [Category("ポケモン - スプライト")]
    [Description("ウルトラサン・ウルトラムーン")]
    public PokemonSpritesPattern8? UltraSunUltraMonn { get; set; }
    #endregion
}
