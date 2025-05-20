using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonSpecies;

/// <summary>
/// ポケモン種族の分類
/// </summary>
public class Genus
{
    #region 分類
    /// <summary>
    /// 分類
    /// </summary>
    [JsonPropertyName("genus")]
    [DisplayName("genus")]
    [Category("ポケモン種族")]
    [Description("分類")]
    public string? GenusName { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    public NamedAPIResource? Language { get; set; }
    #endregion
}
