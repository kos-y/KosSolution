using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.LocationAreas;

/// <summary>
/// 場所エリア
/// </summary>
public class LocationArea
{
    // フィールド

    #region 場所エリアID
    /// <summary>
    /// 場所エリアID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 場所エリア名
    /// <summary>
    /// 場所エリア名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region ゲームIndex
    /// <summary>
    /// ゲームIndex
    /// </summary>
    [JsonPropertyName("game_index")]
    public int? GameIndex { get; set; }
    #endregion

    #region 遭遇方法ごとの確率リスト
    /// <summary>
    /// 遭遇方法ごとの確率リスト
    /// </summary>
    [JsonPropertyName("encounter_method_rates")]
    public List<EncounterMethodRate>? EncounterMethodRates { get; set; }
    #endregion

    #region 場所
    /// <summary>
    /// 場所
    /// </summary>
    [JsonPropertyName("location")]
    public NamedAPIResource? Location { get; set; }
    #endregion

    #region 名前リスト
    /// <summary>
    /// 名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region エンカウントポケモンリスト
    /// <summary>
    /// エンカウントポケモンリスト
    /// </summary>
    [JsonPropertyName("pokemon_encounters")]
    public List<PokemonEncounter>? PokemonEncounters { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static LocationArea? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<LocationArea>(json);
    }
    #endregion
}
