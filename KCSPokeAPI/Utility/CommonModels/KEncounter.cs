using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウント
/// </summary>
public class KEncounter
{
    /// <summary>
    /// 最低レベル
    /// </summary>
    [JsonPropertyName("min_level")]
    public required int MinLevel {  get; set; }

    /// <summary>
    /// 最高レベル
    /// </summary>
    [JsonPropertyName("max_level")]
    public required int MaxLevel { get; set; }

    /// <summary>
    /// エンカウント条件
    /// </summary>
    [JsonPropertyName("condition_values")]
    public required List<KNamedAPIResource> ConditionValues { get; set; }

    /// <summary>
    /// エンカウント確率
    /// </summary>
    [JsonPropertyName("chance")]
    public required int Chance { get; set; }

    /// <summary>
    /// エンカウント方法
    /// </summary>
    [JsonPropertyName("method")]
    public required KNamedAPIResource Method { get; set; }
}
