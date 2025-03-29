using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウントする場所エリア
/// </summary>
public class KLocationAreaEncounter
{
    /// <summary>
    /// 場所エリア
    /// </summary>
    public KNamedAPIResource LocationArea { get; set; }

    /// <summary>
    /// バージョンごとの詳細
    /// </summary>
    public List<KVersionEncounterDetail> VersionDetails { get; set; } = [];
}
