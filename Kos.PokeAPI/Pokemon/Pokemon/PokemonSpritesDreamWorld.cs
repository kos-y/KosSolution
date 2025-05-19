using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン スプライト ドリームワールド
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpritesDreamWorld
{
    #region 正面
    /// <summary>
    /// 正面
    /// </summary>
    [JsonPropertyName("front_default")]
    [DisplayName("front_default")]
    [Category("ポケモン - スプライト - その他 - ドリームワールド")]
    [Description("正面")]
    public string? FrontDefault { get; set; }
    #endregion

    #region 背面
    /// <summary>
    /// 背面
    /// </summary>
    [JsonPropertyName("front_female")]
    [DisplayName("front_female")]
    [Category("ポケモン - スプライト - その他 - ドリームワールド")]
    [Description("背面")]
    public string? BackDefault { get; set; }
    #endregion
}
