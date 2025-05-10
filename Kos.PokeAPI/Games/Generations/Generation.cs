using System.Text.Json.Serialization;
using System.Text.Json;
using Kos.PokeAPI.Utility.CommonModels;
using System.ComponentModel;
using Kos.Core;
using Kos.PokeAPI.Contests.ContestTypes;

namespace Kos.PokeAPI.Games.Generations;

/// <summary>
/// 世代
/// </summary>
public class Generation
{
    // フィールド

    #region 世代ID
    /// <summary>
    /// 世代ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("世代ID")]
    public int? Id { get; set; }
    #endregion

    #region 世代の名前
    /// <summary>
    /// 世代の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("世代の名前")]
    public string? Name { get; set; }
    #endregion

    #region 特性リスト
    /// <summary>
    /// 特性リスト
    /// </summary>
    [JsonPropertyName("abilities")]
    [DisplayName("abilities")]
    [Category("(基本)")]
    [Description("特性リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Abilities { get; set; }
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
    public List<Name>? Names { get; set; }
    #endregion

    #region メイン地域
    /// <summary>
    /// メイン地域
    /// </summary>
    [JsonPropertyName("main_region")]
    [DisplayName("main_region")]
    [Category("(基本)")]
    [Description("メイン地域")]
    public NamedAPIResource? MainRegion { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    [DisplayName("moves")]
    [Category("(基本)")]
    [Description("技リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public List<NamedAPIResource>? Moves { get; set; }
    #endregion

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [DisplayName("pokemon_species")]
    [Category("(基本)")]
    [Description("ポケモン種族リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public List<NamedAPIResource>? PokemonSpecies { get; set; }
    #endregion

    #region タイプリスト
    /// <summary>
    /// タイプリスト
    /// </summary>
    [JsonPropertyName("types")]
    [DisplayName("types")]
    [Category("(基本)")]
    [Description("タイプリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public List<NamedAPIResource>? Types { get; set; }
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
    public List<NamedAPIResource>? VersionGroups { get; set; }
    #endregion


    // メソッド

    #region 世代リソースの取得
    /// <summary>
    /// 世代リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>世代リソース</returns>
    public static Generation? GetGeneration(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Generation>(json);
    }
    #endregion
}
