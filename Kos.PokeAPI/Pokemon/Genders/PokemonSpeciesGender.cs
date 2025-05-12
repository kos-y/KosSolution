using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Genders;

/// <summary>
/// ポケモンごとの性別確率
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonSpeciesGender
{
    #region ポケモン種族
    /// <summary>
    /// ポケモン種族
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [DisplayName("pokemon_species")]
    [Category("(基本")]
    [Description("ポケモン種族")]
    public NamedAPIResource? PokemonSpecies { get; set; }
    #endregion

    #region 確率
    /// <summary>
    /// 確率
    /// </summary>
    [JsonPropertyName("rate")]
    [DisplayName("rate")]
    [Category("(基本)")]
    [Description("確率")]
    public int? Rate { get; set; }
    #endregion
}
