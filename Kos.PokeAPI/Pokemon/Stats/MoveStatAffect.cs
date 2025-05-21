using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Stats;

/// <summary>
/// 技が影響を与えるステータス
/// </summary>
public class MoveStatAffect
{
    #region 技
    /// <summary>
    /// 技
    /// </summary>
    [JsonPropertyName("move")]
    [DisplayName("move")]
    [Category("ステータス")]
    [Description("技")]
    public NamedAPIResource? Move { get; set; }
    #endregion

    #region 変更量
    /// <summary>
    /// 変更量
    /// </summary>
    [JsonPropertyName("change")]
    [DisplayName("change")]
    [Category("ステータス")]
    [Description("変化量")]
    public int? Change { get; set; }
    #endregion
}
