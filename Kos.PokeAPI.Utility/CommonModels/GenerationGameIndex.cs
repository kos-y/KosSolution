using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 世代 ゲームIndex
/// </summary>
public class GenerationGameIndex
{
    // フィールド

    #region ゲームIndex
    /// <summary>
    /// ゲームインデックス
    /// </summary>
    [JsonPropertyName("game_index")]
    public int? GameIndex { get; set; }
    #endregion

    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    public NamedAPIResource? Generation { get; set; }
    #endregion
}
