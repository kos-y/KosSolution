using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウント
/// </summary>
public class KEncounter
{
    /// <summary>
    /// 最低レベル
    /// </summary>
    public int MinLevel {  get; set; }

    /// <summary>
    /// 最高レベル
    /// </summary>
    public int MaxLevel { get; set; }

    /// <summary>
    /// エンカウント条件
    /// </summary>
    public List<KNamedAPIResource> ConditionValues { get; set; } = [];

    /// <summary>
    /// エンカウント確率
    /// </summary>
    public int Chance { get; set; }

    /// <summary>
    /// エンカウント方法
    /// </summary>
    public KNamedAPIResource Method { get; set; }
}
