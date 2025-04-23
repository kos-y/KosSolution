using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Games.Pokedexes;

/// <summary>
/// ポケモン図鑑
/// </summary>
public class Pokedex
{
    // フィールド

    #region ポケモン図鑑ID
    /// <summary>
    /// ポケモン図鑑ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region ポケモン図鑑名
    /// <summary>
    /// ポケモン図鑑名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region メインシリーズか
    /// <summary>
    /// メインシリーズか
    /// </summary>
    [JsonPropertyName("is_main_series")]
    public bool? IsMainSeries { get; set; }
    #endregion

    #region 説明リスト
    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    public List<Description>? Descriptions { get; set; }
    #endregion

    #region ポケモン図鑑名リスト
    /// <summary>
    /// ポケモン図鑑名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region ポケモン登録情報リスト
    /// <summary>
    /// ポケモン登録情報リスト
    /// </summary>
    [JsonPropertyName("pokemon_entries")]
    public List<PokemonEntry>? PokemonEntries { get; set; }
    #endregion

    #region 地域
    /// <summary>
    /// 地域
    /// </summary>
    [JsonPropertyName("region")]
    public NamedAPIResource? Region { get; set; }
    #endregion

    #region バージョングループリスト
    /// <summary>
    /// バージョングループリスト
    /// </summary>
    [JsonPropertyName("version_groups")]
    public List<NamedAPIResource>? VersionGroups { get; set; }
    #endregion


    // メソッド

    #region ポケモン図鑑リソースの取得
    /// <summary>
    /// ポケモン図鑑リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>ポケモン図鑑リソース</returns>
    public static Pokedex? GetPokedex(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Pokedex>(json);
    }
    #endregion
}
