using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// エンカウントポケモン
/// </summary>
public class KPokemonEncounter
{
    /// <summary>
    /// ポケモン
    /// </summary>
    public KNamedAPIResource Pokemon { get; set; }

    /// <summary>
    /// バージョンごとのエンカウント詳細
    /// </summary>
    public List<KVersionEncounterDetail> VersionDetails { get; set; } = [];
}
