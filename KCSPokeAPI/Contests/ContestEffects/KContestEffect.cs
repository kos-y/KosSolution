using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// コンテストの効果
/// </summary>
public class KContestEffect
{
    /// <summary>
    /// コンテストの効果ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// アピールポイント
    /// </summary>
    [JsonPropertyName("appeal")]
    public required int Appeal { get; set; }

    /// <summary>
    /// 妨害ポイント
    /// </summary>
    [JsonPropertyName("jam")]
    public required int Jam { get; set; }

    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    public required List<KEffect> EffectEntries { get; set; }

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    public required List<KFlavorText> FlavorTextEntries { get; set; }


    /// <summary>
    /// コンテストの効果リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>コンテストの効果リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KContestEffect GetContestEffect(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KContestEffect>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
