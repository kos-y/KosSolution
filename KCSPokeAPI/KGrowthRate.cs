using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// レベルアップに必要な経験値の増加量
/// </summary>
public class KGrowthRate
{
    /// <summary>
    /// 経験値増加量ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 経験値増加量名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 計算種別
    /// </summary>
    public string Formula { get; set; } = string.Empty;

    /// <summary>
    /// 説明リスト
    /// </summary>
    public List<KDescription> Descriptions { get; set; } = [];

    /// <summary>
    /// レベルごとの経験値
    /// </summary>
    public List<KGrowthRateExperienceLevel> Levels { get; set; } = [];

    /// <summary>
    /// ポケモン種族リスト
    /// </summary>
    public List<KNamedAPIResource> PokemonSpecies { get; set; } = [];
}
