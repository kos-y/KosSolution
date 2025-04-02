using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン図鑑
/// </summary>
public class KPokedex
{
    /// <summary>
    /// ポケモン図鑑ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// ポケモン図鑑名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// メインシリーズか
    /// </summary>
    [JsonPropertyName("is_main_series")]
    public required bool IsMainSeries { get; set; }

    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    public required List<KDescription> Descriptions { get; set; }

    /// <summary>
    /// ポケモン図鑑名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// ポケモン登録情報リスト
    /// </summary>
    [JsonPropertyName("pokemon_entries")]
    public required List<KPokemonEntry> PokemonEntries { get; set; }

    /// <summary>
    /// 地域
    /// </summary>
    [JsonPropertyName("region")]
    public required KNamedAPIResource Region { get; set; }

    /// <summary>
    /// バージョングループリスト
    /// </summary>
    [JsonPropertyName("version_groups")]
    public required List<KNamedAPIResource> VersionGroups { get; set; }


    /// <summary>
    /// ポケモン図鑑リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>ポケモン図鑑リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KPokedex GetPokedex(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KPokedex>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
