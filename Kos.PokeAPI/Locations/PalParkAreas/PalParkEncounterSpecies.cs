﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Locations.Locations;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Locations.PalParkAreas;

/// <summary>
/// パルパークエリアで遭遇するポケモン種族
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PalParkEncounterSpecies
{
    #region 基本スコア
    /// <summary>
    /// 基本スコア
    /// </summary>
    [JsonPropertyName("base_score")]
    [DisplayName("base_score")]
    [Category("(基本)")]
    [Description("基本スコア")]
    public int? BaseScore { get; set; }
    #endregion

    #region 遭遇率
    /// <summary>
    /// 遭遇率
    /// </summary>
    [JsonPropertyName("rate")]
    [DisplayName("rate")]
    [Category("(基本)")]
    [Description("遭遇率")]
    public int? Rate { get; set; }
    #endregion

    #region ポケモン種族
    /// <summary>
    /// ポケモン種族
    [JsonPropertyName("pokemon_species")]
    [DisplayName("pokemon_species")]
    [Category("(基本)")]
    [Description("ポケモン種族")]
    /// </summary>
    public NamedAPIResource? PokemonSpecies { get; set; }
    #endregion
}
