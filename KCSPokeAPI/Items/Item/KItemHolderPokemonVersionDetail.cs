using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン所持アイテム詳細
/// </summary>
public class KItemHolderPokemonVersionDetail
{
    /// <summary>
    /// 所持確率
    /// </summary>
    [JsonPropertyName("rarity")]
    public required int Rarity { get; set; }

    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    public required KNamedAPIResource Version { get; set; }
}
