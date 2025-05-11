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
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("アイテムカテゴリID")]
    public int? Id { get; set; }
    #endregion

    #region アイテムカテゴリの名前
    /// <summary>
    /// アイテムカテゴリの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("アイテムカテゴリの名前")]
    public string? Name { get; set; }
    #endregion

    #region アイテムリスト
    /// <summary>
    /// アイテムリスト
    /// </summary>
    [JsonPropertyName("items")]
    [DisplayName("items")]
    [Category("(基本)")]
    [Description("アイテムリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public List<NamedAPIResource>? Items { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public List<Name>? Names { get; set; }
    #endregion

    #region ポケット
    /// <summary>
    /// ポケット
    /// </summary>
    [JsonPropertyName("pocket")]
    [DisplayName("pocket")]
    [Category("(基本)")]
    [Description("ポケット")]
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
