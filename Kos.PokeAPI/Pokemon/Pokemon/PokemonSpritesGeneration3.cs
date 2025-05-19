using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - 第3世代
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesGeneration3
{
    #region ルビー・サファイア
    /// <summary>
    /// ルビー・サファイア
    /// </summary>
    [JsonPropertyName("ruby-sapphire")]
    [DisplayName("ruby-sapphire")]
    [Category("ポケモン - スプライト")]
    [Description("ルビー・サファイア")]
    public PokemonSpritesPattern4? RubySapphire { get; set; }
    #endregion

    #region エメラルド
    /// <summary>
    /// エメラルド
    /// </summary>
    [JsonPropertyName("emerald")]
    [DisplayName("emerald")]
    [Category("ポケモン - スプライト")]
    [Description("エメラルド")]
    public PokemonSpritesPattern5? Emerald { get; set; }
    #endregion

    #region ファイアレッド・リーフグリーン
    /// <summary>
    /// ファイアレッド・リーフグリーン
    /// </summary>
    [JsonPropertyName("firered-leafgreen")]
    [DisplayName("firered-leafgreen")]
    [Category("ポケモン - スプライト")]
    [Description("ファイアレッド・リーフグリーン")]
    public PokemonSpritesPattern4? FireRedLeafGreen { get; set; }
    #endregion
}
