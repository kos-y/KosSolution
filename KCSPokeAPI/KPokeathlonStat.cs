using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケスロンのステータス
/// </summary>
public class KPokeathlonStat
{
    /// <summary>
    /// ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 名前リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// 性格が影響受けるステータス
    /// </summary>
    public KNaturePokeathlonStatAffectSets AffectingNatures { get; set; } = new();


}
