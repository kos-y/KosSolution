using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン - スプライト - バージョンごと - 第１世代
/// </summary>
public class PokemonSpritesGeneration1
{
    #region 赤-青
    /// <summary>
    /// 赤-青
    /// </summary>
    [JsonPropertyName("red-blue")]
    [DisplayName("red-blue")]
    [Category("ポケモン - スプライト - 第１世代")]
    [Description("赤-青")]
    public PokemonSpritesPattern1? RedBlue { get; set; }
    #endregion

    #region ピカチュウ
    /// <summary>
    /// ピカチュウ
    /// </summary>
    [JsonPropertyName("yellow")]
    [DisplayName("yellow")]
    [Category("ポケモン - スプライト - 第１世代")]
    [Description("ピカチュウ")]
    public PokemonSpritesPattern1? Yellow { get; set; }
    #endregion
}
