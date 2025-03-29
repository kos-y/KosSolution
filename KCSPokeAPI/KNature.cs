using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 性格
/// </summary>
public class KNature
{
    /// <summary>
    /// 性格ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 性格名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 下降するステータス
    /// </summary>
    public KNamedAPIResource DecreasedStat { get; set; }

    /// <summary>
    /// 上昇するステータス
    /// </summary>
    public KNamedAPIResource IncreasedStat { get; set; }

    /// <summary>
    /// 嫌いなきのみの味
    /// </summary>
    public KNamedAPIResource HatesFlavor { get; set; }

    /// <summary>
    /// 好きなきのみの味
    /// </summary>
    public KNamedAPIResource LikesFlavor { get; set; }

    /// <summary>
    /// 影響を与えるポケスロンのステータス
    /// </summary>
    public List<KNatureStatChange> PokeathlonStatChange { get; set; } = [];

    /// <summary>
    /// 戦闘スタイル
    /// </summary>
    public List<KMoveBattleStylePreference> MoveBattleStylePreferences { get; set; } = [];

    /// <summary>
    /// 性格名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
