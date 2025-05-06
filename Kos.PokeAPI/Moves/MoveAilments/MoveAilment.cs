using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.MoveAilments;

/// <summary>
/// 状態異常技
/// </summary>
public class MoveAilment
{
    #region 状態異常ID
    /// <summary>
    /// 状態異常ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 状態異常名
    /// <summary>
    /// 状態異常名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 状態異常が発動する技リスト
    /// <summary>
    /// 状態異常が発動する技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    public List<NamedAPIResource>? Moves { get; set; }
    #endregion

    #region 状態異常名リスト
    /// <summary>
    /// 状態異常名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static MoveAilment? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<MoveAilment>(json);
    }
    #endregion
}
