using System.Text.Json;
using System.Text.Json.Serialization;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 名前付き APIリソース
/// </summary>
public class NamedAPIResource
{
    // フィールド

    #region リソース名
    /// <summary>
    /// リソース名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    #endregion


    // メソッド

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        return Name ?? Url ?? string.Empty;
        ;
    }
    #endregion
}
