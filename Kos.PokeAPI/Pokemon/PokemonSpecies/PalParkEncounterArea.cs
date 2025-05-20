using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonSpecies;

/// <summary>
/// パルパークの遭遇エリア
/// </summary>
public class PalParkEncounterArea
{
    #region パルパークエリア
    /// <summary>
    /// パルパークエリア
    /// </summary>
    [JsonPropertyName("area")]
    [DisplayName("area")]
    [Category("ポケモン種族")]
    [Description("パルパークエリア")]
    public NamedAPIResource? Area { get; set; }
    #endregion

    #region 基本スコア
    /// <summary>
    /// 基本スコア
    /// </summary>
    [JsonPropertyName("base_score")]
    [DisplayName("base_score")]
    [Category("ポケモン種族")]
    [Description("基本スコア")]
    public int? BaseScore { get; set; }
    #endregion

    #region 遭遇率
    /// <summary>
    /// 遭遇率
    /// </summary>
    [JsonPropertyName("rate")]
    [DisplayName("rate")]
    [Category("ポケモン種族")]
    [Description("遭遇率")]
    public int? Rate { get; set; }
    #endregion
}
