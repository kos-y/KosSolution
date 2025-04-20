using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.BerryFlavors;

/// <summary>
/// 味と木の実のマップ
/// </summary>
public class FlavorBerryMap
{
    // フィールド

    #region 味の強さ
    /// <summary>
    /// 味の強さ
    /// </summary>
    [JsonPropertyName("potency")]
    public int? Potency { get; set; }
    #endregion

    #region 木の実
    /// <summary>
    /// 木の実
    /// </summary>
    [JsonPropertyName("berry")]
    public NamedAPIResource? Berry { get; set; }
    #endregion
}
