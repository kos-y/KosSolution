using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Pokemon.PokeathlonStats;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Stats;

/// <summary>
/// 性格が影響を与えるポケスロンのステータスセット
/// </summary>
public class NatureStatAffectSets
{
    #region 上昇するステータスリスト
    /// <summary>
    /// 上昇するステータスリスト
    /// </summary>
    [JsonPropertyName("increase")]
    [DisplayName("increase")]
    [Category("ステータス")]
    [Description("上昇するステータスリスト")]
    public IReadOnlyList<NamedAPIResource>? Increase { get; set; }
    #endregion

    #region 下降するステータスリスト
    /// <summary>
    /// 下降するステータスリスト
    /// </summary>
    [JsonPropertyName("decrease")]
    [DisplayName("decrease")]
    [Category("ステータス")]
    [Description("下降するステータスリスト")]
    public IReadOnlyList<NamedAPIResource>? Decrease { get; set; }
    #endregion
}
