using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Locations.PalParkAreas;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.Regions;

/// <summary>
/// 地域
/// </summary>
public class Region
{
    #region 地域ID
    /// <summary>
    /// 地域ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("地域ID")]
    public int? Id { get; set; }
    #endregion

    #region 地域の名前
    /// <summary>
    /// 地域の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("地域の名前")]
    public string? Name { get; set; }
    #endregion

    #region 場所リスト
    /// <summary>
    /// 場所リスト
    /// </summary>
    [JsonPropertyName("locations")]
    [DisplayName("locations")]
    [Category("(基本)")]
    [Description("場所リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Locations { get; set; }
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

    #region メインの世代
    /// <summary>
    /// メインの世代
    /// </summary>
    [JsonPropertyName("main_generation")]
    [DisplayName("main_generation")]
    [Category("(基本)")]
    [Description("メインの世代")]
    public NamedAPIResource? MainGeneration { get; set; }
    #endregion

    #region ポケモン図鑑リスト
    /// <summary>
    /// ポケモン図鑑リスト
    /// </summary>
    [JsonPropertyName("pokedexes")]
    [DisplayName("pokedexes")]
    [Category("(基本)")]
    [Description("ポケモン図鑑リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Pokedexes { get; set; }
    #endregion

    #region バージョングループリスト
    /// <summary>
    /// バージョングループリスト
    /// </summary>
    [JsonPropertyName("version_groups")]
    [DisplayName("version_groups")]
    [Category("(基本)")]
    [Description("バージョングループリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? VersionGroups { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Region? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Region>(json);
    }
    #endregion
}
