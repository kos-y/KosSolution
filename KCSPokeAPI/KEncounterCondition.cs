using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウント条件
/// </summary>
public class KEncounterCondition
{
    /// <summary>
    /// エンカウント条件)D
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// エンカウント条件名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// エンカウント条件名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// エンカウント条件値リスト
    /// </summary>
    public List<KNamedAPIResource> Values { get; set; } = [];
}
