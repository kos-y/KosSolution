using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウント条件値
/// </summary>
public class KEncounterConditionValue
{
    /// <summary>
    /// エンカウント条件値ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// エンカウント条件値名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// エンカウント条件
    /// </summary>
    public KNamedAPIResource Condition { get; set; } = new();

    /// <summary>
    /// エンカウント条件値名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
