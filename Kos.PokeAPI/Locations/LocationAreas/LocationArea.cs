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

namespace Kos.PokeAPI.Locations.LocationAreas;

/// <summary>
/// 場所エリア
/// </summary>
public class LocationArea
{
    // フィールド

    #region 場所エリアID
    /// <summary>
    /// 場所エリアID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("場所エリアID")]
    public int? Id { get; set; }
    #endregion

    #region 場所エリアの名前
    /// <summary>
    /// 場所エリアの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("場所エリアの名前")]
    public string? Name { get; set; }
    #endregion

    #region ゲームIndex
    /// <summary>
    /// ゲームIndex
    /// </summary>
    [JsonPropertyName("game_index")]
    [DisplayName("game_index")]
    [Category("(基本)")]
    [Description("ゲームIndex")]
    public int? GameIndex { get; set; }
    #endregion

    #region 遭遇方法ごとの確率リスト
    /// <summary>
    /// 遭遇方法ごとの確率リスト
    /// </summary>
    [JsonPropertyName("encounter_method_rates")]
    [DisplayName("encounter_method_rates")]
    [Category("(基本)")]
    [Description("遭遇方法ごとの確率リスト")]
    [TypeConverter(typeof(ListConverter<EncounterMethodRate>))]
    public IReadOnlyList<EncounterMethodRate>? EncounterMethodRates { get; set; }
    #endregion

    #region 場所
    /// <summary>
    /// 場所
    /// </summary>
    [JsonPropertyName("location")]
    [DisplayName("location")]
    [Category("(基本)")]
    [Description("場所")]
    public NamedAPIResource? Location { get; set; }
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

    #region 遭遇するポケモンリスト
    /// <summary>
    /// 遭遇するポケモンリスト
    /// </summary>
    [JsonPropertyName("pokemon_encounters")]
    [DisplayName("pokemon_encounters")]
    [Category("(基本)")]
    [Description("遭遇するポケモンリスト")]
    [TypeConverter(typeof(ListConverter<PokemonEncounter>))]
    public IReadOnlyList<PokemonEncounter>? PokemonEncounters { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static LocationArea? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<LocationArea>(json);
    }
    #endregion
}
