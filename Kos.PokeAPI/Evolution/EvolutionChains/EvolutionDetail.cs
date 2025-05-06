using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Evolution.EvolutionChains;

/// <summary>
/// 進化詳細
/// </summary>
public class EvolutionDetail
{
    #region アイテム
    /// <summary>
    /// アイテム
    /// </summary>
    [JsonPropertyName("item")]
    public NamedAPIResource? Item { get; set; }
    #endregion

    #region 進化するトリガー
    /// <summary>
    /// 進化するトリガー
    /// </summary>
    [JsonPropertyName("trigger")]
    public NamedAPIResource? Trigger { get; set; }
    #endregion

    #region ポケモンの性別
    /// <summary>
    /// ポケモンの性別
    /// </summary>
    [JsonPropertyName("gender")]
    public int? Gender { get; set; }
    #endregion

    #region 所持アイテム
    /// <summary>
    /// 所持アイテム
    /// </summary>
    [JsonPropertyName("held_item")]
    public NamedAPIResource? HeldItem { get; set; }
    #endregion

    #region 覚えている技
    /// <summary>
    /// 覚えている技
    /// </summary>
    [JsonPropertyName("known_move")]
    public NamedAPIResource? KnownMove { get; set; }
    #endregion

    #region 覚えている技タイプ
    /// <summary>
    /// 覚えている技タイプ
    /// </summary>
    [JsonPropertyName("known_move_type")]
    public NamedAPIResource? KnownMoveType { get; set; }
    #endregion

    #region 進化する場所
    /// <summary>
    /// 進化する場所
    /// </summary>
    [JsonPropertyName("location")]
    public NamedAPIResource? Location { get; set; }
    #endregion

    #region 進化する最低レベル
    /// <summary>
    /// 進化する最低レベル
    /// </summary>
    [JsonPropertyName("min_level")]
    public int? MinLevel { get; set; }
    #endregion

    #region 進化する最低なつき度
    /// <summary>
    /// 進化する最低なつき度
    /// </summary>
    [JsonPropertyName("min_happiness")]
    public int? MinHappiness { get; set; }
    #endregion

    #region 進化する最低美しさ
    /// <summary>
    /// 進化する最低美しさ
    /// </summary>
    [JsonPropertyName("min_beauty")]
    public int? MinBeauty { get; set; }
    #endregion

    #region 進化する最低親密度
    /// <summary>
    /// 進化する最低親密度
    /// </summary>
    [JsonPropertyName("min_affection")]
    public int? MinAffection { get; set; }
    #endregion

    #region 進化条件に天気が関係するか
    /// <summary>
    /// 進化条件に天気が関係するか
    /// </summary>
    [JsonPropertyName("needs_overworld_rain")]
    public required bool NeedsOverworldRain { get; set; }
    #endregion

    #region 進化に必要な手持ち種族
    /// <summary>
    /// 進化に必要な手持ち種族
    /// </summary>
    [JsonPropertyName("party_species")]
    public NamedAPIResource? PartySpecies { get; set; }
    #endregion

    #region 進化に必要な手持ちポケモンタイプ
    /// <summary>
    /// 進化に必要な手持ちポケモンタイプ
    /// </summary>
    [JsonPropertyName("party_type")]
    public NamedAPIResource? PartyType { get; set; }
    #endregion

    #region 攻撃と防御の関係性
    /// <summary>
    /// 攻撃と防御の関係性
    /// </summary>
    /// <remarks>
    ///  1：攻撃 ＞ 防御
    ///  0：攻撃 ＝ 防御
    /// -1：攻撃 ＜ 防御
    /// </remarks>
    [JsonPropertyName("relative_physical_stats")]
    public int? RelativePhysicalStats { get; set; }
    #endregion

    #region 進化する時間帯
    /// <summary>
    /// 進化する時間帯
    /// </summary>
    [JsonPropertyName("time_of_day")]
    public string? TimeOfDay { get; set; } = string.Empty;
    #endregion

    #region 進化する交換条件
    /// <summary>
    /// 進化する交換条件
    /// </summary>
    [JsonPropertyName("trade_species")]
    public NamedAPIResource? TradeSpecies { get; set; }
    #endregion

    #region TurnUpsideDown
    /// <summary>
    /// 進化時にゲーム機を逆さまにする必要があるか
    /// </summary>
    [JsonPropertyName("turn_upside_down")]
    public bool TurnUpsideDown { get; set; }
    #endregion

    #region 文字列
    /// <summary>
    /// 文字列
    /// </summary>
    public string Text => ToString();
    #endregion


    // メソッド

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        List<String> texts = [];

        if (Item is not null) {
            texts.Add($"item:{Item}");
        }

        if (Trigger is not null) {
            texts.Add($"trigger:{Trigger}");
        }

        if (Gender is not null) {
            texts.Add($"gender:{Gender}");
        }

        if (HeldItem is not null) {
            texts.Add($"held_item:{HeldItem}");
        }

        if (KnownMove is not null) {
            texts.Add($"known_move:{KnownMove}");
        }

        if (KnownMoveType is not null) {
            texts.Add($"known_move_type:{KnownMoveType}");
        }

        if (Location is not null) {
            texts.Add($"location:{Location}");
        }

        if (MinLevel is not null) {
            texts.Add($"min_level:{MinLevel}");
        }

        if (MinHappiness is not null) {
            texts.Add($"min_happiness:{MinHappiness}");
        }

        if (MinBeauty is not null) {
            texts.Add($"min_beauty:{MinBeauty}");
        }

        if (MinAffection is not null) {
            texts.Add($"min_affection:{MinAffection}");
        }

        if (NeedsOverworldRain) {
            texts.Add("needs_overworld_rain");
        }

        if (PartySpecies is not null) {
            texts.Add($"party_species:{PartySpecies}");
        }

        if (PartyType is not null) {
            texts.Add($"party_type:{PartyType}");
        }

        if (RelativePhysicalStats is not null) {
            texts.Add($"relative_physical_state:{RelativePhysicalStats}");
        }

        if (!string.IsNullOrWhiteSpace(TimeOfDay)) {
            texts.Add($"time_of_day:{TimeOfDay}");
        }

        if (TradeSpecies is not null) {
            texts.Add($"trade_species:{TradeSpecies}");
        }

        if (TurnUpsideDown) {
            texts.Add("turn_upside_down");
        }

        return string.Join(" / ", texts);
    }
    #endregion
}
