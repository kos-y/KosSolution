using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// パルパークのエンカウントエリア
/// </summary>
public class KPalParkEncounterArea
{
    /// <summary>
    /// 基本スコア
    /// </summary>
    public int BaseScore { get; set; }

    /// <summary>
    /// 確率
    /// </summary>
    public int Rate { get; set; }

    /// <summary>
    /// エリア
    /// </summary>
    public KNamedAPIResource Area { get; set; } = new();
}
