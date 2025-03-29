using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// スーパーコンテストの効果
/// </summary>
public class KSuperContestEffect
{
    /// <summary>
    /// スーパーコンテストの効果ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// アピールポイント
    /// </summary>
    [JsonPropertyName("appeal")]
    public required int Appeal { get; set; }

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    public required List<KFlavorText> FlavorTextEntries { get; set; }

    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    public required List<KNamedAPIResource> Moves { get; set; }


    /// <summary>
    /// スーパーコンテストの効果リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>スーパーコンテストの効果リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KSuperContestEffect GetSuperContestEffect(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KSuperContestEffect>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
