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
/// ポケモン ステータス
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonStat
{
    #region ステータス
    /// <summary>
    /// ステータス
    /// </summary>
    [JsonPropertyName("stat")]
    [DisplayName("stat")]
    [Category("(基本)")]
    [Description("ステータス")]
    public NamedAPIResource? Stat { get; set; }
    #endregion

    #region 種族値
    /// <summary>
    /// 種族値
    /// </summary>
    [JsonPropertyName("base_stat")]
    [DisplayName("base_stat")]
    [Category("(基本)")]
    [Description("種族値")]
    public int? BaseStat { get; set; }
    #endregion

    #region 努力値
    /// <summary>
    /// 努力値
    /// </summary>
    [JsonPropertyName("effort")]
    [DisplayName("effort")]
    [Category("(基本)")]
    [Description("努力値")]
    public int? Effort { get; set; }
    #endregion
}
