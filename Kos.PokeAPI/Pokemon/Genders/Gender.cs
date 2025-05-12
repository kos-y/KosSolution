using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Genders;

/// <summary>
/// 性別
/// </summary>
public class Gender
{
    #region 性別ID
    /// <summary>
    /// 性別ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("(基本)")]
    [Description("性別ID")]
    public int? Id { get; set; }
    #endregion

    #region 性別の名前
    /// <summary>
    /// 性別の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("(基本)")]
    [Description("性別の名前")]
    public string? Name { get; set; }
    #endregion

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species_details")]
    [DisplayName("pokemon_species_details")]
    [Category("(基本)")]
    [Description("ポケモン種族リスト")]
    [TypeConverter(typeof(ListConverter<PokemonSpeciesGender>))]
    public IReadOnlyList<PokemonSpeciesGender>? PokemonSpeciesDetails { get; set; }
    #endregion

    #region 性別が要求される進化
    /// <summary>
    /// 性別が要求される進化
    /// </summary>
    [JsonPropertyName("required_for_evolution")]
    [DisplayName("required_for_evolution")]
    [Category("(基本)")]
    [Description("性別が要求される進化")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? RequiredForEvolution { get; set; }
    #endregion
}
