using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - 第8世代
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesGeneration8
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
}
