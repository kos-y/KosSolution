using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Games.Pokedexes;

/// <summary>
/// ポケモン図鑑エントリー
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonEntry
{
    #region ポケモン図鑑No.
    /// <summary>
    /// ポケモン図鑑No.
    /// </summary>
    [JsonPropertyName("entry_number")]
    [DisplayName("entry_number")]
    [Category("(基本)")]
    [Description("ポケモン図No.")]
    public int? EntryNumber { get; set; }
    #endregion

    #region ポケモン種族
    /// <summary>
    /// ポケモン種族
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [DisplayName("pokemon_species")]
    [Category("(基本)")]
    [Description("ポケモン種族")]
    public NamedAPIResource? PokemonSpecies { get; set; }
    #endregion


    // メソッド

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        return $"{PokemonSpecies}";
    }
    #endregion
}
