using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウントの方法
/// </summary>
public class KEncounterMethod
{
    /// <summary>
    /// エンカウントの方法ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// エンカウントの方法名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 順番
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// エンカウントの方法名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];
}
