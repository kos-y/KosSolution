using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 名前
/// </summary>
public class Name
{
    // フィールド

    #region 名前
    /// <summary>
    /// 名前
    /// </summary>
    [JsonPropertyName("name")]
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
