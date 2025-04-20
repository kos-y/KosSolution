using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Contests.ContestTypes;

/// <summary>
/// コンテストの名前
/// </summary>
public class ContestName
{
    // フィールド

    #region コンテストの名前
    /// <summary>
    /// コンテスト名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 色
    /// <summary>
    /// 色
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    public NamedAPIResource? Language { get; set; }
    #endregion
}
