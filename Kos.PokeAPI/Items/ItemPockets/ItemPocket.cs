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
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("アイテムポケットID")]
    public int? Id { get; set; }
    #endregion

    #region アイテムポケットの名前
    /// <summary>
    /// アイテムポケットの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("アイテムポケットの名前")]
    public string? Name { get; set; }
    #endregion

    #region カテゴリリスト
    /// <summary>
    /// カテゴリリスト
    /// </summary>
    [JsonPropertyName("categories")]
    [DisplayName("categories")]
    [Category("(基本)")]
    [Description("アイテムポケットの名前")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Categories { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
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
