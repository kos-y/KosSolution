using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// 進化チェーンのリンク
/// </summary>
public class KChainLink
{
    /// <summary>
    /// ベビーポケモンか
    /// </summary>
    [JsonPropertyName("is_baby")]
    public required bool IsBaby { get; set; }

    /// <summary>
    /// 種族
    /// </summary>
    [JsonPropertyName("species")]
    public required KNamedAPIResource Species { get; set; }

    /// <summary>
    /// 進化条件詳細リスト
    /// </summary>
    [JsonPropertyName("evolution_details")]
    public required List<KEvolutionDetail> EvolutionDetails { get; set; }

    /// <summary>
    /// 進化先リスト
    /// </summary>
    [JsonPropertyName("evolves_to")]
    public required List<KChainLink> EvolvesTo { get; set; }
}
