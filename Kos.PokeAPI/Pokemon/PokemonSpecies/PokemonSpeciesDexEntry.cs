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
/// ポケモン種族のポケモン図鑑エントリー
/// </summary>
public class PokemonSpeciesDexEntry
{
    #region ポケモン図鑑
    /// <summary>
    /// ポケモン図鑑
    /// </summary>
    [JsonPropertyName("pokedex")]
    [DisplayName("pokedex")]
    [Category("ポケモン種族")]
    [Description("ポケモン図鑑")]
    public NamedAPIResource? Pokedex { get; set; }
    #endregion

    #region 図鑑番号
    /// <summary>
    /// 図鑑番号
    /// </summary>
    [JsonPropertyName("entry_number")]
    [DisplayName("entry_number")]
    [Category("ポケモン種族")]
    [Description("図鑑番号")]
    public int? EntryNumber { get; set; }
    #endregion
}
