using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// 言語
/// </summary>
public class KLanguage
{
    /// <summary>
    /// 言語ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// 言語名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 対応言語か
    /// </summary>
    [JsonPropertyName("official")]
    public required bool Official { get; set; }

    /// <summary>
    /// ISO639コード
    /// </summary>
    [JsonPropertyName("iso639")]
    public required string ISO639 { get; set; }

    /// <summary>
    /// ISO3166コード
    /// </summary>
    [JsonPropertyName("iso3166")]
    public required string ISO3166 { get; set; }

    /// <summary>
    /// 名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }


    /// <summary>
    /// 言語リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>言語リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KLanguage GetLanguage(string url)
    {
        string json = KPokeAPIClient.GetAPIResourceListEndPoint(url);

        return JsonSerializer.Deserialize<KLanguage>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
