using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Contests.SuportContestEffects;

/// <summary>
/// スーパーコンテスト 効果
/// </summary>
public class SuperContestEffect
{
    // フィールド

    #region スーパーコンテストの効果ID
    /// <summary>
    /// スーパーコンテストの効果ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region アピールポイント
    /// <summary>
    /// アピールポイント
    /// </summary>
    [JsonPropertyName("appeal")]
    public int? Appeal { get; set; }
    #endregion

    #region フレーバーテキストリスト
    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    public List<FlavorText>? FlavorTextEntries { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    public List<NamedAPIResource>? Moves { get; set; }
    #endregion


    // 静的メソッド

    #region スーパーコンテストの効果リソースの取得
    /// <summary>
    /// スーパーコンテストの効果リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>スーパーコンテストの効果リソース</returns>
    public static SuperContestEffect? GetSuperContestEffect(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<SuperContestEffect>(json);
    }
    #endregion
}
