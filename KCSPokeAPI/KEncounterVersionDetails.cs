using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// バージョンごとのエンカウント詳細
/// </summary>
public class KEncounterVersionDetails
{
    /// <summary>
    /// エンカウント確率
    /// </summary>
    public int Rage { get; set; }

    /// <summary>
    /// バージョン
    /// </summary>
    public KNamedAPIResource Version { get; set; }
}
