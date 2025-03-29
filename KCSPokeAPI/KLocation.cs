using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 場所
/// </summary>
public class KLocation
{
    /// <summary>
    /// 場所ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 場所名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 地域
    /// </summary>
    public KNamedAPIResource Region { get; set; }

    /// <summary>
    /// 場所名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// 世代ごとのゲームIndexリスト
    /// </summary>
    public List<KGenerationGameIndex> GameIndices { get; set; } = [];

    /// <summary>
    /// エリアリスト
    /// </summary>
    public List<KNamedAPIResource> Areas { get; set; } = [];
}
