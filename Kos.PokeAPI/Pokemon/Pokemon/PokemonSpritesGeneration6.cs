using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - 第6世代
/// </summary>
public class PokemonSpritesGeneration6
{
    #region X・Y
    /// <summary>
    /// X・Y
    /// </summary>
    [JsonPropertyName("x-y")]
    [DisplayName("x-y")]
    [Category("ポケモン - スプライト")]
    [Description("X・Y")]
    public PokemonSpritesPattern8? XY { get; set; }
    #endregion

    #region オメガルビー・アルファサファイア
    /// <summary>
    /// オメガルビー・アルファサファイア
    /// </summary>
    [JsonPropertyName("omegaruby-alphasapphire")]
    [DisplayName("omegaruby-alphasapphire")]
    [Category("ポケモン - スプライト")]
    [Description("オメガルビー・あるいふぁサファイア")]
    public PokemonSpritesPattern8? OmegaRubyAlphaSapphire { get; set; }
    #endregion
}
