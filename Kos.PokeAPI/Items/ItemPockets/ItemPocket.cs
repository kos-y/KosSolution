using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items.ItemPockets;

/// <summary>
/// アイテムポケット
/// </summary>
public class ItemPocket
{
    #region アイテムポケットID
    /// <summary>
    /// アイテムポケットID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region アイテムポケット名
    /// <summary>
    /// アイテムポケット名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region カテゴリリスト
    /// <summary>
    /// カテゴリリスト
    /// </summary>
    [JsonPropertyName("categories")]
    public List<NamedAPIResource>? Categories { get; set; }
    #endregion

    #region アイテムポケット名リスト
    /// <summary>
    /// アイテムポケット名リスト
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
    /// <exception cref="Exception"></exception>
    public static ItemPocket? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<ItemPocket>(json);
    }
    #endregion
}
