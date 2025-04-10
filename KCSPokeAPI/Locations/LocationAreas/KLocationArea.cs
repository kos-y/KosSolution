using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 場所エリア
/// </summary>
public class KLocationArea
{
    /// <summary>
    /// 場所エリアID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// 場所エリア名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// ゲームIndex
    /// </summary>
    [JsonPropertyName("game_index")]
    public required int GameIndex { get; set; }

    /// <summary>
    /// エンカウント方法ごとの確率リスト
    /// </summary>
    [JsonPropertyName("encounter_method_rates")]
    public required List<KEncounterMethodRate> EncounterMethodRates { get; set; }

    /// <summary>
    /// 場所
    /// </summary>
    [JsonPropertyName("location")]
    public required KNamedAPIResource Location { get; set; }

    /// <summary>
    /// 名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// エンカウントポケモンリスト
    /// </summary>
    [JsonPropertyName("pokemon_encounters")]
    public required List<KPokemonEncounter> PokemonEncounters { get; set; }


    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    /// <exception cref="Exception"></exception>
    public static KLocationArea GetResource(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KLocationArea>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
