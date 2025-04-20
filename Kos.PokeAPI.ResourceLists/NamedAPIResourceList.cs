using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.ResourceLists;

/// <summary>
/// 名前付き API リソースリスト
/// </summary>
public class NamedAPIResourceList
{
    // フィールド

    #region 件数
    /// <summary>
    /// 件数
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }
    #endregion

    #region 次ページへのURL
    /// <summary>
    /// 次ページへのURL
    /// </summary>
    [JsonPropertyName("next")]
    public string? Next { get; set; }
    #endregion

    #region 前ページへのURL
    /// <summary>
    /// 前ページへのURL
    /// </summary>
    [JsonPropertyName("previous")]
    public string? Previous { get; set; }
    #endregion

    #region 結果リスト
    /// <summary>
    /// 結果リスト
    /// </summary>
    [JsonPropertyName("results")]
    public List<NamedAPIResource>? Results { get; set; }
    #endregion


    // メソッド

    #region 名前付きAPIリソースリストの取得
    /// <summary>
    /// 名前付きAPIリソースリストの取得
    /// </summary>
    /// <param name="endPoint">エンド・ポイント</param>
    /// <returns>名前付きAPIリソースリスト</returns>
    /// <exception cref="Exception"></exception>
    public static NamedAPIResourceList GetNamedAPIResourceList(string endPoint)
    {
        string json = PokeAPIClient.GetAPIResourceListEndPoint(endPoint);

        return
            JsonSerializer.Deserialize<NamedAPIResourceList>(json) ??
            throw new Exception("Failed to parse JSON string.");
    }
    #endregion

    #region 名前付きAPIリソースリストの取得
    /// <summary>
    /// 名前付きAPIリソースリストの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>名前付きAPIリソースリスト</returns>
    /// <exception cref="Exception"></exception>
    public static NamedAPIResourceList GetNamedAPIResourceListUrl(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return
            JsonSerializer.Deserialize<NamedAPIResourceList>(json) ??
            throw new Exception("Failed to parse JSON string.");
    }
    #endregion
}
