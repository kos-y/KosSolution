using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 個性
/// </summary>
public class KCharacteristic
{
    /// <summary>
    /// 個性ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 個性の条件値（個体値を５で割った余り）
    /// </summary>
    public int GeneModulo { get; set; }

    /// <summary>
    /// 特性に該当する数値リスト
    /// </summary>
    public List<int> PossibleValues { get; set; } = [];

    /// <summary>
    /// 最高ステータス
    /// </summary>
    public KNamedAPIResource HighestStat { get; set; } = new();

    /// <summary>
    /// 説明リスト
    /// </summary>
    public List<KDescription> Descriptions { get; set; } = [];
}
