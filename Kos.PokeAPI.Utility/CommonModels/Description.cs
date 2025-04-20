using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 説明
/// </summary>
public class Description
{
    // フィールド

    #region 説明
    /// <summary>
    /// 説明
    /// </summary>
    [JsonPropertyName("description")]
    public string? Text { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    public NamedAPIResource? Language { get; set; }
    #endregion
}
