using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 遭遇
/// </summary>
public class Encounter
{
    #region 最低レベル
    /// <summary>
    /// 最低レベル
    /// </summary>
    [JsonPropertyName("min_level")]
    public int? MinLevel { get; set; }
    #endregion

    #region 最高レベル
    /// <summary>
    /// 最高レベル
    /// </summary>
    [JsonPropertyName("max_level")]
    public int? MaxLevel { get; set; }
    #endregion

    #region 遭遇条件値
    /// <summary>
    /// 遭遇条件値
    /// </summary>
    [JsonPropertyName("condition_values")]
    public List<NamedAPIResource>? ConditionValues { get; set; }
    #endregion

    #region 遭遇率
    /// <summary>
    /// 遭遇率
    /// </summary>
    [JsonPropertyName("chance")]
    public int? Chance { get; set; }
    #endregion

    #region 遭遇方法
    /// <summary>
    /// 遭遇方法
    /// </summary>
    [JsonPropertyName("method")]
    public NamedAPIResource? Method { get; set; }
    #endregion
}
