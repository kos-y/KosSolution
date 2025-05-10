using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Utility.Languages;

/// <summary>
/// 言語
/// </summary>
public class Language
{
    // フィールド

    #region 言語ID
    /// <summary>
    /// 言語ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 言語名
    /// <summary>
    /// 言語名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 対応言語か
    /// <summary>
    /// 対応言語か
    /// </summary>
    [JsonPropertyName("official")]
    public bool? Official { get; set; }
    #endregion

    #region ISO639コード
    /// <summary>
    /// ISO639コード
    /// </summary>
    [JsonPropertyName("iso639")]
    public string? Iso639 { get; set; }
    #endregion

    #region ISO3166コード
    /// <summary>
    /// ISO3166コード
    /// </summary>
    [JsonPropertyName("iso3166")]
    public string? Iso3166 { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion


    // メソッド

    #region 言語リソースの取得
    /// <summary>
    /// 言語リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>言語リソース</returns>
    public static Language? GetLanguage(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Language>(json);
    }
    #endregion
}
