using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモンの鳴き声
/// </summary>
public class PokemonCries
{
    #region 最新の鳴き声
    /// <summary>
    /// 最新の鳴き声
    /// </summary>
    [JsonPropertyName("latest")]
    [DisplayName("latest")]
    [Category("(基本)")]
    [Description("最新の鳴き声")]
    public string? Latest { get; set; }
    #endregion

    #region 過去の鳴き声
    /// <summary>
    /// 過去の鳴き声
    /// </summary>
    [JsonPropertyName("legacy")]
    [DisplayName("legacy")]
    [Category("(基本)")]
    [Description("過去の鳴き声")]
    public string? Legacy { get; set; }
    #endregion
}
