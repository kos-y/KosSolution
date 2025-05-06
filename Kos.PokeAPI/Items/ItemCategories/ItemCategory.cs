using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items.ItemCategories;

/// <summary>
/// アイテムカテゴリー
/// </summary>
public class ItemCategory
{
    #region アイテムカテゴリID
    /// <summary>
    /// アイテムカテゴリID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region アイテムカテゴリ名
    /// <summary>
    /// アイテムカテゴリ名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region アイテムリスト
    /// <summary>
    /// アイテムリスト
    /// </summary>
    [JsonPropertyName("items")]
    public List<NamedAPIResource>? Items { get; set; }
    #endregion

    #region アイテムカテゴリ名リスト
    /// <summary>
    /// アイテムカテゴリ名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region ポケット
    /// <summary>
    /// ポケット
    /// </summary>
    [JsonPropertyName("pocket")]
    public NamedAPIResource? Pocket { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static ItemCategory? GetItemCategory(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<ItemCategory>(json);
    }
    #endregion
}
