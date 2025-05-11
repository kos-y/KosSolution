using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Locations.Locations;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.PalParkAreas;

/// <summary>
/// パルパークエリア
/// </summary>
public class PalParkArea
{
    #region パルパークエリアID
    /// <summary>
    /// パルパークエリアID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("パルパークエリアID")]
    public int? Id { get; set; }
    #endregion

    #region パルパークエリアの名前
    /// <summary>
    /// パルパークエリアの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("パルパークエリアの名前")]
    public string? Name { get; set; }
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

    #region 遭遇するポケモン種族リスト
    /// <summary>
    /// 遭遇するポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_encounters")]
    [DisplayName("pokemon_encounters")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<PalParkEncounterSpecies>))]
    public IReadOnlyList<PalParkEncounterSpecies>? PokemonEncounters { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static PalParkArea? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<PalParkArea>(json);
    }
    #endregion
}
