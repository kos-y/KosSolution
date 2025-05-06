using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Games.Pokedexes;

/// <summary>
/// ポケモン図鑑エントリー
/// </summary>
public class PokemonEntry
{
    #region ポケモン図鑑No.
    /// <summary>
    /// ポケモン図鑑No.
    /// </summary>
    [JsonPropertyName("entry_number")]
    public int? EntryNumber { get; set; }
    #endregion

    #region ポケモン種族
    /// <summary>
    /// ポケモン種族
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    public NamedAPIResource? PokemonSpecies { get; set; }
    #endregion
}
