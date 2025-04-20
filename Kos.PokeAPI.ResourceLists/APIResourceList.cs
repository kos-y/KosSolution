using System.Text.Json;
using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.ResourceLists;

/// <summary>
/// API リソースリスト
/// </summary>
public class APIResourceList
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
    public required string? Previous { get; set; }
    #endregion

    #region 結果リスト
    /// <summary>
    /// 結果リスト
    /// </summary>
    [JsonPropertyName("results")]
    public required List<APIResource> Results { get; set; }
    #endregion


    // 静的メソッド

    #region API リソースリストの取得
    /// <summary>
    /// API リソースリストの取得
    /// </summary>
    /// <param name="endPoint">エンド・ポイント</param>
    /// <returns>API リソースリスト</returns>
    /// <exception cref="Exception">JSON文字列の解析に失敗</exception>
    public static APIResourceList GetAPIResourceList(string endPoint)
    {
        string json = PokeAPIClient.GetAPIResourceListEndPoint(endPoint);

        return
            JsonSerializer.Deserialize<APIResourceList>(json) ??
            throw new Exception("Failed to parse JSON string.");
    }
    #endregion
}
