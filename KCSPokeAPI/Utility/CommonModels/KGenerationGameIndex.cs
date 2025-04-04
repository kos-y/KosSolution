using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ゲームインデックスごとの世代
/// </summary>
public class KGenerationGameIndex
{
    /// <summary>
    /// ゲームインデックス
    /// </summary>
    [JsonPropertyName("game_index")]
    public required int GameIndex { get; set; }

    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    public required KNamedAPIResource Generation { get; set; }
}
