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
using Kos.PokeAPI.Items.Item;

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
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("アイテム特性ID")]
    public int? Id { get; set; }
    #endregion

    #region アイテム特性の名前
    /// <summary>
    /// アイテム特性の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("アイテム特性の名前")]
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
    public IReadOnlyList<NamedAPIResource>? Items { get; set; }
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

    #region 言語ごとの説明リスト
    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    [DisplayName("descriptions")]
    [Category("(基本)")]
    [Description("言語ごとの説明リスト")]
    [TypeConverter(typeof(ListConverter<Description>))]
    public IReadOnlyList<Description>? Descriptions { get; set; }
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
