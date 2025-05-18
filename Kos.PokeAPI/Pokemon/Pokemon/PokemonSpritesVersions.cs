using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン スプライト バージョン
/// </summary>
public class PokemonSpritesVersions
{
    #region 第1世代
    /// <summary>
    /// 第1世代
    /// </summary>
    [JsonPropertyName("generation-i")]
    [DisplayName("generation-i")]
    [Category("ポケモン - スプライト")]
    [Description("第1世代")]
    public PokemonSpritesGeneration1? Generation1 { get; set; }
    #endregion

    #region 第2世代
    /// <summary>
    /// 第2世代
    /// </summary>
    [JsonPropertyName("generation-ii")]
    [DisplayName("generation-ii")]
    [Category("ポケモン - スプライト")]
    [Description("第2世代")]
    public PokemonSpritesGeneration2? Generation2 { get; set; }
    #endregion

    #region 第3世代
    /// <summary>
    /// 第3世代
    /// </summary>
    [JsonPropertyName("generation-iii")]
    [DisplayName("generation-iii")]
    [Category("ポケモン - スプライト")]
    [Description("第3世代")]
    public PokemonSpritesGeneration3? Generation3 { get; set; }
    #endregion

    #region 第4世代
    /// <summary>
    /// 第4世代
    /// </summary>
    [JsonPropertyName("generation-iv")]
    [DisplayName("generation-iv")]
    [Category("ポケモン - スプライト")]
    [Description("第4世代")]
    public PokemonSpritesGeneration4? Generation4 { get; set; }
    #endregion

    #region 第5世代
    /// <summary>
    /// 第5世代
    /// </summary>
    [JsonPropertyName("generation-v")]
    [DisplayName("generation-v")]
    [Category("ポケモン - スプライト")]
    [Description("第5世代")]
    public PokemonSpritesGeneration5? Generation5 { get; set; }
    #endregion

    #region 第6世代
    /// <summary>
    /// 第6世代
    /// </summary>
    [JsonPropertyName("generation-vi")]
    [DisplayName("generation-vi")]
    [Category("ポケモン - スプライト")]
    [Description("第6世代")]
    public PokemonSpritesGeneration6? Generation6 { get; set; }
    #endregion

    #region 第7世代
    /// <summary>
    /// 第7世代
    /// </summary>
    [JsonPropertyName("generation-vii")]
    [DisplayName("generation-vii")]
    [Category("ポケモン - スプライト")]
    [Description("第7世代")]
    public PokemonSpritesGeneration7? Generation7 { get; set; }
    #endregion

    #region 第8世代
    /// <summary>
    /// 第8世代
    /// </summary>
    [JsonPropertyName("generation-viii")]
    [DisplayName("generation-viii")]
    [Category("ポケモン - スプライト")]
    [Description("第8世代")]
    public PokemonSpritesGeneration8? Generation8 { get; set; }
    #endregion
}
