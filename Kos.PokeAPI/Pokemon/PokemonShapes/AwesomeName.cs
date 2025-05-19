using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokemonShapes;

/// <summary>
/// 愛称
/// </summary>
public class AwesomeName
{
    #region 愛称
    /// <summary>
    /// 愛称
    /// </summary>
    [JsonPropertyName("awesome_name")]
    [DisplayName("awesome_name")]
    [Category("愛称")]
    [Description("愛称")]
    public string? Name { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    [DisplayName("language")]
    [Category("愛称")]
    [Description("言語")]
    public NamedAPIResource? Language { get; set; }
    #endregion
}
