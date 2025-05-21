using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.Stats;

/// <summary>
/// 技が影響を与えるステータスセット
/// </summary>
public class MoveStatAffectSets
{
    #region いい影響を与えるステータス
    /// <summary>
    /// いい影響を与えるステータス
    /// </summary>
    [JsonPropertyName("increase")]
    [DisplayName("increase")]
    [Category("ステータス")]
    [Description("いい影響を与えるステータス")]
    public IReadOnlyList<MoveStatAffect>? Increase { get; set; }
    #endregion

    #region 悪い影響を与えるステータス
    /// <summary>
    /// 悪い影響を与えるステータス
    /// </summary>
    [JsonPropertyName("decrease")]
    [DisplayName("decrease")]
    [Category("ステータス")]
    [Description("悪い影響を与えるステータス")]
    public IReadOnlyList<MoveStatAffect>? Decrease { get; set; }
    #endregion
}
