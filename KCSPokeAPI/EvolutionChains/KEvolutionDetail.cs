using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 進化詳細
/// </summary>
public class KEvolutionDetail
{
    /// <summary>
    /// アイテム
    /// </summary>
    [JsonPropertyName("item")]
    public required KNamedAPIResource? Item { get; set; }

    /// <summary>
    /// 進化するトリガー
    /// </summary>
    [JsonPropertyName("trigger")]
    public required KNamedAPIResource? Trigger { get; set; }

    /// <summary>
    /// ポケモンの性別
    /// </summary>
    [JsonPropertyName("gender")]
    public required int? Gender { get; set; }

    /// <summary>
    /// 所持アイテム
    /// </summary>
    [JsonPropertyName("held_item")]
    public required KNamedAPIResource? HeldItem { get; set; }

    /// <summary>
    /// 覚えている技
    /// </summary>
    [JsonPropertyName("known_move")]
    public required KNamedAPIResource? KnownMove { get; set; }

    /// <summary>
    /// 覚えている技タイプ
    /// </summary>
    [JsonPropertyName("known_move_type")]
    public required KNamedAPIResource? KnownMoveType { get; set; }

    /// <summary>
    /// 進化する場所
    /// </summary>
    [JsonPropertyName("location")]
    public required KNamedAPIResource? Location { get; set; }

    /// <summary>
    /// 進化する最低レベル
    /// </summary>
    [JsonPropertyName("min_level")]
    public required int? MinLevel { get; set; }

    /// <summary>
    /// 進化する最低なつき度
    /// </summary>
    [JsonPropertyName("min_happiness")]
    public required int? MinHappiness { get; set; }

    /// <summary>
    /// 進化する最低美しさ
    /// </summary>
    [JsonPropertyName("min_beauty")]
    public required int? MinBeauty { get; set; }

    /// <summary>
    /// 進化する最低親密度
    /// </summary>
    [JsonPropertyName("min_affection")]
    public required int? MinAffection { get; set; }

    /// <summary>
    /// 進化条件に天気が関係するか
    /// </summary>
    [JsonPropertyName("needs_overworld_rain")]
    public required bool NeedsOverworldRain { get; set; }

    /// <summary>
    /// 進化に必要な手持ち種族
    /// </summary>
    [JsonPropertyName("party_species")]
    public required KNamedAPIResource? PartySpecies { get; set; }

    /// <summary>
    /// 進化に必要な手持ちポケモンタイプ
    /// </summary>
    [JsonPropertyName("party_type")]
    public required KNamedAPIResource? PartyType { get; set; }

    /// <summary>
    /// 攻撃と防御の関係性
    /// </summary>
    /// <remarks>
    ///  1：攻撃 ＞ 防御
    ///  0：攻撃 ＝ 防御
    /// -1：攻撃 ＜ 防御
    /// </remarks>
    [JsonPropertyName("relative_physical_stats")]
    public required int? RelativePhysicalStats { get; set; }

    /// <summary>
    /// 進化する時間帯
    /// </summary>
    [JsonPropertyName("time_of_day")]
    public required string? TimeOfDay { get; set; } = string.Empty;

    /// <summary>
    /// 進化する交換条件
    /// </summary>
    [JsonPropertyName("trade_species")]
    public required KNamedAPIResource? TradeSpecies { get; set; }

    /// <summary>
    /// 進化時にゲーム機を逆さまにする必要があるか
    /// </summary>
    [JsonPropertyName("turn_upside_down")]
    public required bool TurnUpsideDown { get; set; }
}
