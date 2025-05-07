using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.MoveCategories;

/// <summary>
/// 技のカテゴリ
/// </summary>
public class MoveCategory
{
    #region 技のカテゴリID
    /// <summary>
    /// 技のカテゴリID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 技のカテゴリ名
    /// <summary>
    /// 技のカテゴリ名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    public List<NamedAPIResource>? Moves { get; set; }
    #endregion

    #region 説明リスト
    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    public List<Description>? Descriptions { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static MoveCategory? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<MoveCategory>(json);
    }
    #endregion
}
