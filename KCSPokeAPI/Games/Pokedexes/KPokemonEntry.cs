using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン登録情報
/// </summary>
public class KPokemonEntry
{
    /// <summary>
    /// ポケモン図鑑No.
    /// </summary>
    [JsonPropertyName("entry_number")]
    public required int EntryNumber { get; set; }

    /// <summary>
    /// ポケモン種族
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    public required KNamedAPIResource PokemonSpecies { get; set; }
}
