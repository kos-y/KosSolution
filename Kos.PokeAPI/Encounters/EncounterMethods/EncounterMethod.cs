using System.Text.Json.Serialization;
using System.Text.Json;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Encounters.EncounterMethods;

/// <summary>
/// 遭遇方法
/// </summary>
public class EncounterMethod
{
    // フィールド

    #region エンカウントの方法ID
    /// <summary>
    /// エンカウントの方法ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region エンカウントの方法名
    /// <summary>
    /// エンカウントの方法名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 順番
    /// <summary>
    /// 順番
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }
    #endregion

    #region エンカウントの方法名リスト
    /// <summary>
    /// エンカウントの方法名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion


    // 静的メソッド

    #region エンカウントの方法リソースの取得
    /// <summary>
    /// エンカウントの方法リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>エンカウントの方法リソース</returns>
    public static EncounterMethod? GetEncountMethod(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<EncounterMethod>(json);
    }
    #endregion
}
