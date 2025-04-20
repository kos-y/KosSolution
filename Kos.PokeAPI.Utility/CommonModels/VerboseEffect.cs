using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 効果 詳細
/// </summary>
public class VerboseEffect
{
    // フィールド

    #region 効果 詳細
    /// <summary>
    /// 効果 詳細
    /// </summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }
    #endregion

    #region 効果 簡易
    /// <summary>
    /// 効果 簡易
    /// </summary>
    [JsonPropertyName("short_effect")]
    public string? ShortEffect { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    public NamedAPIResource? Language { get; set; }
    #endregion
}
