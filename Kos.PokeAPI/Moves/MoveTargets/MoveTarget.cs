using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.MoveTargets;

/// <summary>
/// 技の対象
/// </summary>
public class MoveTarget
{
    #region 技の対象ID
    /// <summary>
    /// 技の対象ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 技の対象名
    /// <summary>
    /// 技の対象名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 説明リスト
    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    public List<Description>? Descriptions { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    public List<NamedAPIResource>? Moves { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
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
    public static MoveTarget? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<MoveTarget>(json);
    }
    #endregion
}
