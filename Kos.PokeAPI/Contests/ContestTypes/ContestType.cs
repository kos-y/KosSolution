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
using Kos.PokeAPI.Berries.Berries;

namespace Kos.PokeAPI.Contests.ContestTypes;

/// <summary>
/// コンテストの種類
/// </summary>
public class ContestType
{
    // フィールド

    #region コンテストの種類ID
    /// <summary>
    /// コンテストの種類ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("コンテストの種類ID")]
    public int? Id { get; set; }
    #endregion

    #region コンテストの種類の名前
    /// <summary>
    /// コンテストの種類の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("コンテストの種類の名前")]
    public string? Name { get; set; }
    #endregion

    #region きのみの味
    /// <summary>
    /// きのみの味
    /// </summary>
    [JsonPropertyName("berry_flavor")]
    [DisplayName("berry_flavor")]
    [Category("(基本)")]
    [Description("きのみの味")]
    public required NamedAPIResource BerryFlavor { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<ContestName>))]
    public IReadOnlyList<ContestName>? Names { get; set; }
    #endregion


    // メソッド

    #region コンテストの部門の取得
    /// <summary>
    /// コンテストの部門の取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>コンテストの部門</returns>
    public static ContestType? GetContestType(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<ContestType>(json);
    }
    #endregion
}
