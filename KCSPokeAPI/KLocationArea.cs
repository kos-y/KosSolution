using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 場所エリア
/// </summary>
public class KLocationArea
{
    /// <summary>
    /// 場所エリアID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 場所エリア名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// ゲームIndex
    /// </summary>
    public int GameIndex { get; set; }

    /// <summary>
    /// エンカウント方法ごとの確率リスト
    /// </summary>
    public List<KEncounterMethod> EncounterMethodRates { get; set; } = [];

    /// <summary>
    /// 場所
    /// </summary>
    public KNamedAPIResource Location { get; set; }

    /// <summary>
    /// エンカウントポケモンリスト
    /// </summary>
    public List<KPokemonEncounter> PokemonEncounters { get; set; } = [];
}
