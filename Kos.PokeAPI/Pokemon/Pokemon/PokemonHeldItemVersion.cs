using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモン所持アイテム バージョン
/// </summary>
public class PokemonHeldItemVersion
{
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

    #region 確率
    /// <summary>
    /// 確率
    /// </summary>
    [JsonPropertyName("rarity")]
    [DisplayName("rarity")]
    [Category("(基本)")]
    [Description("確率")]
    public int? Rarity { get; set; }
    #endregion
}
