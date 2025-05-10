using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Berries.Berries;
using Kos.PokeAPI.Items.Item;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.BerryFirmnesses;

/// <summary>
/// きのみの固さ
/// </summary>
public class BerryFirmness
{
    // フィールド

    #region きのみの硬さID
    /// <summary>
    /// きのみの硬さID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("基本")]
    [Description("きのみの硬さID")]
    public int? Id { get; set; }
    #endregion

    #region きのみの硬さの名前
    /// <summary>
    /// きのみの硬さの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("基本")]
    [Description("きのみの硬さの名前")]
    public string? Name { get; set; }
    #endregion

    #region きのみリスト
    /// <summary>
    /// きのみリスト
    /// </summary>
    [JsonPropertyName("berries")]
    [DisplayName("berries")]
    [Category("基本")]
    [Description("きのみリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    [ReadOnly(true)]
    public IReadOnlyList<NamedAPIResource>? Berries { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("基本")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    [ReadOnly(true)]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion


    // メソッド

    #region きのみの硬さリソースの取得
    /// <summary>
    /// きのみの硬さリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>きのみの硬さリソース</returns>
    public static BerryFirmness? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<BerryFirmness>(json);
    }
    #endregion
}
