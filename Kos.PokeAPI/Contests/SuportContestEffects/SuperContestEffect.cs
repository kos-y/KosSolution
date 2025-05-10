using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;
using System.ComponentModel;
using Kos.Core;
using Kos.PokeAPI.Contests.ContestTypes;

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
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("スーパーコンテストの効果ID")]
    public int? Id { get; set; }
    #endregion

    #region アピールポイント
    /// <summary>
    /// アピールポイント
    /// </summary>
    [JsonPropertyName("appeal")]
    [DisplayName("appeal")]
    [Category("(基本)")]
    [Description("アピールポイント")]
    public int? Appeal { get; set; }
    #endregion

    #region フレーバーテキストリスト
    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [DisplayName("flavor_text_entries")]
    [Category("(基本)")]
    [Description("フレーバーテキストリスト")]
    [TypeConverter(typeof(ListConverter<FlavorText>))]
    public IReadOnlyList<FlavorText>? FlavorTextEntries { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    [DisplayName("moves")]
    [Category("(基本)")]
    [Description("技リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
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
