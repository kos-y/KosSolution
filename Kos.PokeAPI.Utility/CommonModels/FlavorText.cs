using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// フレーバーテキスト
/// </summary>
public class FlavorText
{
    // フィールド

    #region フレーバーテキスト
    /// <summary>
    /// フレーバーテキスト
    /// </summary>
    [JsonPropertyName("flavor_text")]
    public string? Text { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    public NamedAPIResource? Language { get; set; }
    #endregion

    #region バージョン
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    public NamedAPIResource? Version { get; set; }
    #endregion
}
