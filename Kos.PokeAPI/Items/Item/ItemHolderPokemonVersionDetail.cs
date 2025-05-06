using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items;

/// <summary>
/// ポケモン所持アイテム詳細
/// </summary>
public class ItemHolderPokemonVersionDetail
{
    #region 所持確率
    /// <summary>
    /// 所持確率
    /// </summary>
    [JsonPropertyName("rarity")]
    public int? Rarity { get; set; }
    #endregion

    #region バージョン
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    public NamedAPIResource? Version { get; set; }
    #endregion
}
