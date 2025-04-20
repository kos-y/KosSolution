using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Contests.ContestTypes;

/// <summary>
/// コンテストの部門
/// </summary>
public class ContestType
{
    // フィールド

    #region コンテストの部門ID
    /// <summary>
    /// コンテストの部門ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; set; }
    #endregion

    #region コンテストの部門名
    /// <summary>
    /// コンテストの部門名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    #endregion

    #region 木の実の味
    /// <summary>
    /// きのみの味
    /// </summary>
    [JsonPropertyName("berry_flavor")]
    public required NamedAPIResource BerryFlavor { get; set; }
    #endregion

    #region コンテストの部門名リスト
    /// <summary>
    /// コンテストの部門名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<ContestName>? Names { get; set; }
    #endregion


    // メソッド

    #region コンテストの部門の取得
    /// <summary>
    /// コンテストの部門の取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>コンテストの部門</returns>
    public static ContestType? GetContestType(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<ContestType>(json);
    }
    #endregion
}
