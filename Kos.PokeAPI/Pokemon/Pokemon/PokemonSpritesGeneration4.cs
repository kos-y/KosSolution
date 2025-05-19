using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - 第4世代
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesGeneration4
{
    #region ダイアモンド・パール
    /// <summary>
    /// ダイアモンド・パール
    /// </summary>
    [JsonPropertyName("diamond-pearl")]
    [DisplayName("diamond-parl")]
    [Category("ポケモン - スプライト")]
    [Description("ダイアモンド・パール")]
    public PokemonSpritesPattern6? DiamondPearl { get; set; }
    #endregion

    #region プラチナ
    /// <summary>
    /// プラチナ
    /// </summary>
    [JsonPropertyName("platinum")]
    [DisplayName("platinum")]
    [Category("ポケモン - スプライト")]
    [Description("プラチナ")]
    public PokemonSpritesPattern6? Platinum { get; set; }
    #endregion

    #region ハードゴールド・ソウルシルバー
    /// <summary>
    /// ハードゴールド・ソウルシルバー
    /// </summary>
    [JsonPropertyName("heartgold-soulsilver")]
    [DisplayName("heartgold-soulsilver")]
    [Category("ポケモン - スプライト")]
    [Description("ハートゴールド・ソウルシールド")]
    public PokemonSpritesPattern6? HartGoldSoulSilver { get; set; }
    #endregion
}
