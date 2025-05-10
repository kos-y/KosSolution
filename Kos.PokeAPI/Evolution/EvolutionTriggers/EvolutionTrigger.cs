using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;
using Kos.Core;
using Kos.PokeAPI.Evolution.EvolutionChains;

namespace Kos.PokeAPI.Evolution.EvolutionTriggers;

/// <summary>
/// 進化発動条件
/// </summary>
public class EvolutionTrigger
{
    // フィールド

    #region 進化発動条件ID
    /// <summary>
    /// 進化発動条件
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("進化発動条件")]
    public int? Id { get; set; }
    #endregion

    #region 進化発動条件の名前
    /// <summary>
    /// 進化発動条件の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("進化発動条件の名前")]
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

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [DisplayName("pokemon_species")]
    [Category("(基本)")]
    [Description("ポケモン種族")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public List<NamedAPIResource>? PokemonSpecies { get; set; }
    #endregion


    // メソッド

    #region 進化トリガーリソースの取得
    /// <summary>
    /// 進化トリガーリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>進化トリガーリソース</returns>
    public static EvolutionTrigger? GetEvolutionTrigger(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<EvolutionTrigger>(json);
    }
    #endregion
}
