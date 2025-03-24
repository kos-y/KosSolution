using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技マシン バージョン 詳細
/// </summary>
public class KMachineVersionDetail
{
    /// <summary>
    /// 技マシン
    /// </summary>
    public KAPIResource Machine { get; set; } = new();

    /// <summary>
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup { get; set; } = new();
}
