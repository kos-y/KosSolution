using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 世代 ゲームIndex
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class GenerationGameIndex
{
    // フィールド

    #region ゲームIndex
    /// <summary>
    /// ゲームインデックス
    /// </summary>
    [JsonPropertyName("game_index")]
    [DisplayName("game_index")]
    [Category("(基本)")]
    [Description("ゲームIndex")]
    public int? GameIndex { get; set; }
    #endregion

    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    [DisplayName("generation")]
    [Category("(基本)")]
    [Description("世代")]
    public NamedAPIResource? Generation { get; set; }
    #endregion
}
