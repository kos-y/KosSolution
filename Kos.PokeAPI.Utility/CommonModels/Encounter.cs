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
    /// <summary>
    /// 最低レベル
    /// </summary>
    [JsonPropertyName("min_level")]
    public int? MinLevel { get; set; }

    /// <summary>
    /// 最高レベル
    /// </summary>
    [JsonPropertyName("max_level")]
    public int? MaxLevel { get; set; }

    /// <summary>
    /// エンカウント条件
    /// </summary>
    [JsonPropertyName("condition_values")]
    public List<NamedAPIResource>? ConditionValues { get; set; }

    /// <summary>
    /// エンカウント確率
    /// </summary>
    [JsonPropertyName("chance")]
    public int? Chance { get; set; }

    /// <summary>
    /// エンカウント方法
    /// </summary>
    [JsonPropertyName("method")]
    public NamedAPIResource? Method { get; set; }
}
