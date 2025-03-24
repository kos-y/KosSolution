using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 進化詳細
/// </summary>
public class KEvolutionDetail
{
    /// <summary>
    /// 進化詳細ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 進化するトリガー
    /// </summary>
    public KNamedAPIResource Trigger { get; set; } = new();

    /// <summary>
    /// ポケモンの性別
    /// </summary>
    public int Gender { get; set; }

    /// <summary>
    /// 所持アイテム
    /// </summary>
    public KNamedAPIResource HeldItem { get; set; } = new();

    /// <summary>
    /// 覚えている技
    /// </summary>
    public KNamedAPIResource KnownMove { get; set; } = new();

    /// <summary>
    /// 覚えている技タイプ
    /// </summary>
    public KNamedAPIResource KnownMoveType { get; set; } = new();

    /// <summary>
    /// 進化する場所
    /// </summary>
    public KNamedAPIResource Location { get; set; } = new();

    /// <summary>
    /// 進化する最低レベル
    /// </summary>
    public int MinLevel { get; set; }

    /// <summary>
    /// 進化する最低なつき度
    /// </summary>
    public int MinHappiness { get; set; }

    /// <summary>
    /// 進化する最低美しさ
    /// </summary>
    public int MinBeauty { get; set; }

    /// <summary>
    /// 進化する最低親密度
    /// </summary>
    public int MinAffection { get; set; }

    /// <summary>
    /// 進化条件に天気が関係するか
    /// </summary>
    public bool NeedsOverworldRain { get; set; }

    /// <summary>
    /// 進化に必要な手持ち種族
    /// </summary>
    public KNamedAPIResource PartySpecies { get; set; } = new();

    /// <summary>
    /// 進化に必要な手持ちポケモンタイプ
    /// </summary>
    public KNamedAPIResource PartyType { get; set; } = new();

    /// <summary>
    /// 攻撃と防御の関係性
    /// </summary>
    /// <remarks>
    ///  1：攻撃 ＞ 防御
    ///  0：攻撃 ＝ 防御
    /// -1：攻撃 ＜ 防御
    /// </remarks>
    public int RelativePhysicalStatus { get; set; }

    /// <summary>
    /// 進化する時間帯
    /// </summary>
    public string TimeOfDay { get; set; } = string.Empty;

    /// <summary>
    /// 進化する交換条件
    /// </summary>
    public KNamedAPIResource TrageSpecies { get; set; } = new();

    /// <summary>
    /// 進化時にゲーム機を逆さまにする必要があるか
    /// </summary>
    public bool TurnUpsideDown { get; set; }
}
