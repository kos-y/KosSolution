using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - 第5世代
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesGeneration5
{
    #region ブラック・ホワイト
    /// <summary>
    /// ブラック・ホワイト
    /// </summary>
    [JsonPropertyName("black-white")]
    [DisplayName("black-white")]
    [Category("ポケモン - スプライト")]
    [Description("ブラック・ホワイト")]
    public PokemonSpritesPattern7? BackWhilte { get; set; }
    #endregion
}
