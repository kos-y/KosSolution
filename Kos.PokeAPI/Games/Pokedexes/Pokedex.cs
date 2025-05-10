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

namespace Kos.PokeAPI.Games.Pokedexes;

/// <summary>
/// ポケモン図鑑
/// </summary>
public class Pokedex
{
    // フィールド

    #region ポケモン図鑑ID
    /// <summary>
    /// ポケモン図鑑ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("ポケモン図鑑ID")]
    public int? Id { get; set; }
    #endregion

    #region ポケモン図鑑の名前
    /// <summary>
    /// ポケモン図鑑の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("ポケモン図鑑の名前")]
    public string? Name { get; set; }
    #endregion

    #region メインシリーズか
    /// <summary>
    /// メインシリーズか
    /// </summary>
    [JsonPropertyName("is_main_series")]
    [DisplayName("is_main_series")]
    [Category("(基本)")]
    [Description("メインシリーズかどうか")]
    public bool? IsMainSeries { get; set; }
    #endregion

    #region 言語ごとの説明リスト
    /// <summary>
    /// 言語ごとの説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    [DisplayName("is_main_series")]
    [Category("(基本)")]
    [Description("言語ごとの説明リスト")]
    [TypeConverter(typeof(ListConverter<Description>))]
    public IReadOnlyList<Description>? Descriptions { get; set; }
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

    #region ポケモン登録情報リスト
    /// <summary>
    /// ポケモン登録情報リスト
    /// </summary>
    [JsonPropertyName("pokemon_entries")]
    [DisplayName("pokemon_entries")]
    [Category("(基本)")]
    [Description("ポケモン登録情報リスト")]
    [TypeConverter(typeof(ListConverter<PokemonEntry>))]
    public IReadOnlyList<PokemonEntry>? PokemonEntries { get; set; }
    #endregion

    #region 地域
    /// <summary>
    /// 地域
    /// </summary>
    [JsonPropertyName("region")]
    [DisplayName("region")]
    [Category("(基本)")]
    [Description("地域")]
    public NamedAPIResource? Region { get; set; }
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

    #region ポケモン図鑑リソースの取得
    /// <summary>
    /// ポケモン図鑑リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>ポケモン図鑑リソース</returns>
    public static Pokedex? GetPokedex(string url)
    {
        // 全国図鑑取得時にSystem.Text.Json.JsonExceptionが1回発生しているので、５回リトライ

        for (int i = 0; i < 5; i++) {
            try {
                string json = PokeAPIClient.GetAPIResourceUrl(url);

                return JsonSerializer.Deserialize<Pokedex>(json);
            } catch (JsonException) {
            }
        }

        return null;
    }
    #endregion
}
