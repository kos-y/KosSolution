using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン スプライト その他
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesOther
{
    #region ドリームワールド
    /// <summary>
    /// ドリームワールド
    /// </summary>
    [JsonPropertyName("dream_world")]
    [DisplayName("dream_world")]
    [Category("ポケモン - スプライト - その他")]
    [Description("ドリームワールド")]
    public PokemonSpritesDreamWorld? DreamWorld { get; set; }
    #endregion

    #region ポケモンHOME
    /// <summary>
    /// ポケモンHOME
    /// </summary>
    [JsonPropertyName("home")]
    [DisplayName("home")]
    [Category("ポケモン - スプライト - その他")]
    [Description("ポケモンHOME")]
    public PokemonSpritesHome? Home { get; set; }
    #endregion

    #region オフィシャルアートワーク
    /// <summary>
    /// オフィシャルアートワーク
    /// </summary>
    [JsonPropertyName("official-artwork")]
    [DisplayName("official-artwork")]
    [Category("ポケモン - スプライト - その他")]
    [Description("オフィシャルアートワーク")]
    public PokemonSpritesOfficialArtwork? Artwork { get; set; }
    #endregion

    #region Pokemon Showdown!
    /// <summary>
    /// Pokemon Showdown!
    /// </summary>
    [JsonPropertyName("showdown")]
    [DisplayName("showdown")]
    [Category("ポケモン - スプライト - その他")]
    [Description("Pokemon Showdown!")]
    public PokemonSpritesShowdown? Showdown { get; set; }
    #endregion
}
