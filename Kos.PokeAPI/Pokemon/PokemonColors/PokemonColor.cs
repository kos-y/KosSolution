using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonColors;

/// <summary>
/// ポケモンの色
/// </summary>
public class PokemonColor
{
    #region ポケモンの色ID
    /// <summary>
    /// ポケモンの色ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("ポケモンの色")]
    [Description("ポケモンの色ID")]
    public int? Id { get; set; }
    #endregion

    #region ポケモンの色の名前
    /// <summary>
    /// ポケモンの色の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("ポケモンの色")]
    [Description("ポケモンの色の名前")]
    public string? Name { get; set; }
    #endregion

    #region 言語ごとの名前
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("names")]
    [Category("ポケモンの色")]
    [Description("言語ごとの名前リスト")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [DisplayName("poekmon_species")]
    [Category("ポケモンの色")]
    [Description("ポケモン種族リスト")]
    public IReadOnlyList<NamedAPIResource>? PokemonSpecies { get; set; }
    #endregion
}
