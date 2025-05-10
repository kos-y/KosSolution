using System.ComponentModel;
using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items;

/// <summary>
/// ポケモン所持アイテム詳細
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ItemHolderPokemonVersionDetail
{
    #region 所持確率
    /// <summary>
    /// 所持確率
    /// </summary>
    [JsonPropertyName("rarity")]
    [DisplayName("rarity")]
    [Category("(基本)")]
    [Description("所持確率")]
    public int? Rarity { get; set; }
    #endregion

    #region バージョン
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    [DisplayName("version")]
    [Category("(基本)")]
    [Description("バージョン")]
    public NamedAPIResource? Version { get; set; }
    #endregion
}
