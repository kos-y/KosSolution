using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.Berries;

/// <summary>
/// 木の実と味のマップ
/// </summary>
public class BerryFlavorMap
{
    // フィールド

    #region 味の強さ
    /// <summary>
    /// 味の強さ
    /// </summary>
    [JsonPropertyName("potency")]
    public int? Potency { get; set; }
    #endregion

    #region 味
    /// <summary>
    /// 味
    /// </summary>
    [JsonPropertyName("flavor")]
    public NamedAPIResource? Flavor { get; set; }
    #endregion
}
