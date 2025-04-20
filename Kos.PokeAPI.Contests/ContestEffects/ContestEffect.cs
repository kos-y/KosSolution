using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Contests.ContestEffects;

/// <summary>
/// コンテスト効果
/// </summary>
public class ContestEffect
{
    // フィールド

    #region コンテストの効果ID
    /// <summary>
    /// コンテストの効果ID
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

    #region 妨害ポイント
    /// <summary>
    /// 妨害ポイント
    /// </summary>
    [JsonPropertyName("jam")]
    public int? Jam { get; set; }
    #endregion

    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    public List<Effect>? EffectEntries { get; set; }
    #endregion

    #region フレーバーテキストリスト
    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    public List<FlavorText>? FlavorTextEntries { get; set; }
    #endregion


    // メソッド

    #region コンテストの効果リソースの取得
    /// <summary>
    /// コンテストの効果リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>コンテストの効果リソース</returns>
    public static ContestEffect? GetContestEffect(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<ContestEffect>(json);
    }
    #endregion
}
