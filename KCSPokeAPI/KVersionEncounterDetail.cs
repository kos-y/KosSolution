using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// バージョンごとのエンカウント詳細
/// </summary>
public class KVersionEncounterDetail
{
    /// <summary>
    /// バージョン
    /// </summary>
    public KNamedAPIResource Version { get; set; } = new();

    /// <summary>
    /// エンカウントの最大確率
    /// </summary>
    public int MaxChance { get; set; }

    /// <summary>
    /// エンカウントの詳細
    /// </summary>
    public List<KEncounter> EncounterDetails { get; set; } = [];
}
