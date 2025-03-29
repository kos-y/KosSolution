using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウント方法の確率
/// </summary>
public class KEncounterMethodRate
{
    /// <summary>
    /// エンカウント方法
    /// </summary>
    public KNamedAPIResource EncounterMethod { get; set; }

    /// <summary>
    /// バージョンごとのエンカウント詳細
    /// </summary>
    public List<KVersionEncounterDetail> VersionDetails { get; set; } = [];
}
