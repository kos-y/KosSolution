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
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("コンテストの効果ID")]
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

    #region 妨害ポイント
    /// <summary>
    /// 妨害ポイント
    /// </summary>
    [JsonPropertyName("jam")]
    [DisplayName("jam")]
    [Category("(基本)")]
    [Description("妨害ポイント")]
    public int? Jam { get; set; }
    #endregion

    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [DisplayName("effect_entries")]
    [Category("(基本)")]
    [Description("効果リスト")]
    [TypeConverter(typeof(ListConverter<Effect>))]
    public IReadOnlyList<Effect>? EffectEntries { get; set; }
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
