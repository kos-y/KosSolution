using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items.ItemAttributes;

/// <summary>
/// アイテム特性
/// </summary>
public class ItemAttribute
{
    #region アイテム特性ID
    /// <summary>
    /// アイテム特性ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region アイテム特性名
    /// <summary>
    /// アイテム特性名
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

    #region アイテム特性名リスト
    /// <summary>
    /// アイテム特性名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region 説明リスト
    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    public List<Description>? Descriptions { get; set; }
    #endregion


    // メソッド

    #region アイテム特性リソースの取得
    /// <summary>
    /// アイテム特性リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>アイテム特性リソース</returns>
    public static ItemAttribute? GetItemAttribute(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<ItemAttribute>(json);
    }
    #endregion
}
