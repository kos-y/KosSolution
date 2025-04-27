using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items.ItemFlingEffects;

/// <summary>
/// 「なげつける」の効果
/// </summary>
public class ItemFlingEffect
{
    #region 効果ID
    /// <summary>
    /// 効果ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 効果名
    /// <summary>
    /// 効果名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    public List<Effect>? EffectEntries { get; set; }
    #endregion

    #region アイテムリスト
    /// <summary>
    /// アイテムリスト
    /// </summary>
    [JsonPropertyName("items")]
    public List<NamedAPIResource>? Items { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static ItemFlingEffect? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<ItemFlingEffect>(json);
    }
    #endregion
}
