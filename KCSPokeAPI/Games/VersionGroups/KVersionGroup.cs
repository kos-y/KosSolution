using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// バージョングループ
/// </summary>
public class KVersionGroup
{
    /// <summary>
    /// バージョングループID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// バージョングループ名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 順番
    /// </summary>
    [JsonPropertyName("order")]
    public required int Order { get; set; }

    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    public required KNamedAPIResource Generation { get; set; }

    /// <summary>
    /// 技の習得方法リスト
    /// </summary>
    [JsonPropertyName("move_learn_methods")]
    public required List<KNamedAPIResource> MoveLearnMethods { get; set; }

    /// <summary>
    /// ポケモン図鑑リスト
    /// </summary>
    [JsonPropertyName("pokedexes")]
    public required List<KNamedAPIResource> Pokedexes { get; set; }

    /// <summary>
    /// 地域リスト
    /// </summary>
    [JsonPropertyName("regions")]
    public required List<KNamedAPIResource> Regions { get; set; }

    /// <summary>
    /// バージョンリスト
    /// </summary>
    [JsonPropertyName("versions")]
    public required List<KNamedAPIResource> Version { get; set; }


    /// <summary>
    /// バージョングループリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>バージョングループリソース</returns>
    /// <exception cref="Exception"></exception>
    public static KVersionGroup GetVersionGroup(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KVersionGroup>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
