using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// バージョン ゲームIndex
/// </summary>
public class VersionGameIndex
{
    // フィールド

    #region ゲームIndex
    /// <summary>
    /// ゲームインデックス
    /// </summary>
    [JsonPropertyName("game_index")]
    public int? GameIndex { get; set; }
    #endregion

    #region バージョン
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    public NamedAPIResource? Version { get; set; }
    #endregion
}
