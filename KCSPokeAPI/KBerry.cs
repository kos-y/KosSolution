using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// きのみ
/// </summary>
public class KBerry
{
    /// <summary>
    /// きのみID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// きのみ名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 成長時間
    /// </summary>
    public int GrowthTime { get; set; }

    /// <summary>
    /// 1回の収穫で取得できる最大数（第４世代以降）
    /// </summary>
    public int MaxHarvest { get; set; }

    /// <summary>
    /// 「しぜんのめぐみ」の威力
    /// </summary>
    public int NaturalGiftPower { get; set; }

    /// <summary>
    /// きのみのサイズ
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// 滑らかさ
    /// </summary>
    public int Smoothness { get; set; }

    /// <summary>
    /// 土壌を乾燥させる速度
    /// </summary>
    public int SoilDryness { get; set; }

    /// <summary>
    /// 固さ
    /// </summary>
    public KNamedAPIResource Firmness { get; set; } = new();

    /// <summary>
    /// 味リスト
    /// </summary>
    public List<KFlavorBerryMap> Flavors { get; set; } = [];

    /// <summary>
    /// アイテム
    /// </summary>
    public KNamedAPIResource Item { get; set; } = new();

    /// <summary>
    /// 「しぜんのめぐみ」の技タイプ
    /// </summary>
    public KNamedAPIResource NaturalGiftType { get; set; } = new();
}
