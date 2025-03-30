using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// 進化チェーン
/// </summary>
public class KEvolutionChain
{
    /// <summary>
    /// 進化チェーンID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// ベビーポケモンが進化するアイテム
    /// </summary>
    [JsonPropertyName("baby_trigger_item")]
    public required KNamedAPIResource? BabyTriggerItem { get; set; }

    /// <summary>
    /// チェーン
    /// </summary>
    [JsonPropertyName("chain")]
    public required KChainLink Chain { get; set; }


    /// <summary>
    /// 進化チェーンリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>進化チェーンリソース</returns>
    /// <exception cref="Exception"></exception>
    public static KEvolutionChain GetEvolutionChain(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KEvolutionChain>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
