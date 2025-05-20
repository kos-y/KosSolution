using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonSpecies;

/// <summary>
/// ポケモン種族のバリエーション
/// </summary>
public class PokemonSpeciesVariety
{
    #region ポケモン
    /// <summary>
    /// ポケモン
    /// </summary>
    [JsonPropertyName("pokemon")]
    [DisplayName("pokemon")]
    [Category("ポケモン種族")]
    [Description("ポケモン")]
    public IReadOnlyList<NamedAPIResource>? Pokemon { get; set; }
    #endregion

    #region ポケモン種族
    /// <summary>
    /// デフォルトの種族か
    /// </summary>
    [JsonPropertyName("is_default")]
    [DisplayName("is_default")]
    [Category("ポケモン種族")]
    [Description("デフォルトの種族か")]
    public bool? IsDefault { get; set; }
    #endregion
}
