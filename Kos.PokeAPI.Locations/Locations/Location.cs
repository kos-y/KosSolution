using System.Text.Json.Serialization;
using System.Text.Json;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.Locations;

/// <summary>
/// 場所
/// </summary>
public class Location
{
    #region 場所ID
    /// <summary>
    /// 場所ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 場所名
    /// <summary>
    /// 場所名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 地域
    /// <summary>
    /// 地域
    /// </summary>
    [JsonPropertyName("region")]
    public NamedAPIResource? Region { get; set; }
    #endregion

    #region 場所名リスト
    /// <summary>
    /// 場所名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region 世代ごとのゲームIndexリスト
    /// <summary>
    /// 世代ごとのゲームIndexリスト
    /// </summary>
    [JsonPropertyName("game_indices")]
    public List<GenerationGameIndex>? GameIndices { get; set; }
    #endregion

    #region エリアリスト
    /// <summary>
    /// エリアリスト
    /// </summary>
    [JsonPropertyName("areas")]
    public List<NamedAPIResource>? Areas { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Location? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Location>(json);
    }
    #endregion
}
