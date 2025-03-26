using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// レベルごとに必要な経験値
/// </summary>
public class KGrowthRateExperienceLevel
{
    /// <summary>
    /// レベル
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// 経験値
    /// </summary>
    public int Experience { get; set; }
}
