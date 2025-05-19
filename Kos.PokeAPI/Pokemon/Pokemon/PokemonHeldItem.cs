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
/// ポケモンの所持アイテム
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonHeldItem
{
    #region アイテム
    /// <summary>
    /// アイテム
    /// </summary>
    [JsonPropertyName("item")]
    [DisplayName("item")]
    [Category("(基本)")]
    [Description("アイテム")]
    public NamedAPIResource? Item { get; set; }
    #endregion

    #region バージョンごとの詳細情報
    /// <summary>
    /// バージョンごとの詳細情報
    /// </summary>
    [JsonPropertyName("version_details")]
    [DisplayName("version_details")]
    [Category("(基本)")]
    [Description("バージョンごとの詳細")]
    public IReadOnlyList<PokemonHeldItemVersion>? VersionDetails { get; set; }
    #endregion
}
