using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 過去のタイプ相性
/// </summary>
public class KTypeRelationsPast
{
    /// <summary>
    /// 世代
    /// </summary>
    public KNamedAPIResource Generation { get; set; }

    /// <summary>
    /// タイプ相性
    /// </summary>
    public KTypeRelations DamageRelations { get; set; }
}
