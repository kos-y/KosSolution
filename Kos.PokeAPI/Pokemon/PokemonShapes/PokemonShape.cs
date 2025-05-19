using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonShapes;

/// <summary>
/// ポケモン形状
/// </summary>
public class PokemonShape
{
    #region ポケモンの形状ID
    /// <summary>
    /// ポケモンの形状ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("ポケモンの形状")]
    [Description("ポケモンの形状ID")]
    public int? Id { get; set; }
    #endregion

    #region ポケモンの形状の名前
    /// <summary>
    /// ポケモンの形状の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("ポケモンの形状")]
    [Description("ポケモンの形状の名前")]
    public string? Name { get; set; }
    #endregion

    #region 言語ごとの愛称リスト
    /// <summary>
    /// 言語ごとの愛称リスト
    /// </summary>
    [JsonPropertyName("awesome_names")]
    [DisplayName("awesome_names")]
    [Category("ポケモンの形状")]
    [Description("言語ごとの愛称リスト")]
    public IReadOnlyList<AwesomeName>? AwesomeNames { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("ポケモンの形状")]
    [Description("言語ごとの名前リスト")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region ポケモン種族リスト
    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [DisplayName("pokemon_species")]
    [Category("ポケモンの形状")]
    [Description("ぽえ毛門種族リスト")]
    public IReadOnlyList<NamedAPIResource>? PokemonSpecies { get; set; }
    #endregion
}
