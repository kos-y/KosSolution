using System.Text.Json.Serialization;
using System.Text.Json;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Games.Generations;

/// <summary>
/// 世代
/// </summary>
public class Generation
{
    // フィールド

    #region 世代ID
    /// <summary>
    /// 世代ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 世代名
    /// <summary>
    /// 世代名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 特性リスト
    /// <summary>
    /// 特性リスト
    /// </summary>
    [JsonPropertyName("abilities")]
    public List<NamedAPIResource>? Abilities { get; set; }
    #endregion

    #region 世代名リスト
    /// <summary>
    /// 世代名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region メイン地域
    /// <summary>
    /// メイン地域
    /// </summary>
    [JsonPropertyName("main_region")]
    public NamedAPIResource? MainRegion { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    public List<NamedAPIResource>? Moves { get; set; }
    #endregion

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    public List<NamedAPIResource>? PokemonSpecies { get; set; }
    #endregion

    #region タイプリスト
    /// <summary>
    /// タイプリスト
    /// </summary>
    [JsonPropertyName("types")]
    public List<NamedAPIResource>? Types { get; set; }
    #endregion

    #region バージョングループリスト
    /// <summary>
    /// バージョングループリスト
    /// </summary>
    [JsonPropertyName("version_groups")]
    public List<NamedAPIResource>? VersionGroups { get; set; }
    #endregion


    // メソッド

    #region 世代リソースの取得
    /// <summary>
    /// 世代リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>世代リソース</returns>
    public static Generation? GetGeneration(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Generation>(json);
    }
    #endregion
}
