using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン所持アイテム
/// </summary>
public class KItemHolderPokemon
{
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    public required KNamedAPIResource Pokemon { get; set; }

    /// <summary>
    /// 詳細リスト
    /// </summary>
    [JsonPropertyName("version_details")]
    public required List<KItemHolderPokemonVersionDetail> VersionDetails { get; set; }
}
