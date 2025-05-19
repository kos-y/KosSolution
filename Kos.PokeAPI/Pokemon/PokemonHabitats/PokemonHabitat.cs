using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonHabitats;

/// <summary>
/// 生息環境
/// </summary>
public class PokemonHabitat
{
    #region 生息環境ID
    /// <summary>
    /// 生息環境ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("生息環境")]
    [Description("生息環境ID")]
    public int? Id { get; set; }
    #endregion

    #region 生息環境の名前
    /// <summary>
    /// ポケモン 生息環境の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("生息環境")]
    [Description("生息環境の名前")]
    public string? Name { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("生息環境")]
    [Description("言語ごとの名前リスト")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("poskemon_species")]
    [DisplayName("pokemon_species")]
    [Category("生息環境")]
    [Description("ポケモン種族リスト")]
    public IReadOnlyList<NamedAPIResource>? PokemonSpecies { get; set; }
    #endregion
}
