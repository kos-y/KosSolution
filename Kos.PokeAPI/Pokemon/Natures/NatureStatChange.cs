using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Natures;

/// <summary>
/// 性格がポケスロンに影響を与えるステータス
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class NatureStatChange
{
    #region ポケスロンのステータス
    /// <summary>
    /// ポケスロンのステータス
    /// </summary>
    [JsonPropertyName("pokeathlon_stat")]
    [DisplayName("pokeathlon_stat")]
    [Category("(基本)")]
    [Description("ポケスロンのステータス")]
    public NamedAPIResource? PokeathlonStat { get; set; }
    #endregion

    #region 最大変化量
    /// <summary>
    /// 最大変化量
    /// </summary>
    [JsonPropertyName("max_change")]
    [DisplayName("max_change")]
    [Category("(基本")]
    [Description("最大変化量")]
    public int? MaxChange { get; set; }
    #endregion
}
