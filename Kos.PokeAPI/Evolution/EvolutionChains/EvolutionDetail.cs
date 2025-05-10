using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Evolution.EvolutionChains;

/// <summary>
/// 進化詳細
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EvolutionDetail
{
    #region 進化発動条件
    /// <summary>
    /// 進化発動条件
    /// </summary>
    [JsonPropertyName("trigger")]
    [DisplayName("trigger")]
    [Category("(基本)")]
    [Description("進化発動条件")]
    public NamedAPIResource? Trigger { get; set; }
    #endregion

    #region 使用するアイテム
    /// <summary>
    /// 使用するアイテム
    /// </summary>
    [JsonPropertyName("item")]
    [DisplayName("item")]
    [Category("ポケモン - アイテム")]
    [Description("使用するアイテム")]
    public NamedAPIResource? Item { get; set; }
    #endregion

    #region 持たせるアイテム
    /// <summary>
    /// 持たせるアイテム
    /// </summary>
    [JsonPropertyName("held_item")]
    [DisplayName("held_item")]
    [Category("ポケモン - アイテム")]
    [Description("持たせるアイテム")]
    public NamedAPIResource? HeldItem { get; set; }
    #endregion

    #region ポケモンの性別
    /// <summary>
    /// ポケモンの性別
    /// </summary>
    [JsonPropertyName("gender")]
    [DisplayName("gender")]
    [Category("ポケモン")]
    [Description("ポケモンの性別")]
    public int? Gender { get; set; }
    #endregion

    #region 覚えている技
    /// <summary>
    /// 覚えている技
    /// </summary>
    [JsonPropertyName("known_move")]
    [DisplayName("known_move")]
    [Category("ポケモン - 覚えている技")]
    [Description("覚えている技")]
    public NamedAPIResource? KnownMove { get; set; }
    #endregion

    #region 覚えている技タイプ
    /// <summary>
    /// 覚えている技タイプ
    /// </summary>
    [JsonPropertyName("known_move_type")]
    [DisplayName("known_move_type")]
    [Category("ポケモン - 覚えている技")]
    [Description("覚えている技タイプ")]
    public NamedAPIResource? KnownMoveType { get; set; }
    #endregion

    #region 進化する場所
    /// <summary>
    /// 進化する場所
    /// </summary>
    [JsonPropertyName("location")]
    [DisplayName("location")]
    [Category("その他")]
    [Description("場所")]
    public NamedAPIResource? Location { get; set; }
    #endregion

    #region 進化する最低レベル
    /// <summary>
    /// 進化する最低レベル
    /// </summary>
    [JsonPropertyName("min_level")]
    [DisplayName("min_level")]
    [Category("ポケモン - 最低値")]
    [Description("進化する最低レベル")]
    public int? MinLevel { get; set; }
    #endregion

    #region 進化する最低なつき度
    /// <summary>
    /// 進化する最低なつき度
    /// </summary>
    [JsonPropertyName("min_happiness")]
    [DisplayName("min_happiness")]
    [Category("ポケモン - 最低値")]
    [Description("進化する最低なつき度")]
    public int? MinHappiness { get; set; }
    #endregion

    #region 進化する最低かっこよさ
    /// <summary>
    /// 進化する最低かっこよさ
    /// </summary>
    [JsonPropertyName("min_beauty")]
    [DisplayName("min_happiness")]
    [Category("ポケモン - 最低値")]
    [Description("進化する最低かっこよさ")]
    public int? MinBeauty { get; set; }
    #endregion

    #region 進化する最低親密度
    /// <summary>
    /// 進化する最低親密度
    /// </summary>
    [JsonPropertyName("min_affection")]
    [DisplayName("min_affection")]
    [Category("ポケモン - 最低値")]
    [Description("進化する最低親密度")]
    public int? MinAffection { get; set; }
    #endregion

    #region 進化条件に天気が関係するか
    /// <summary>
    /// 進化条件に天気が関係するか
    /// </summary>
    [JsonPropertyName("needs_overworld_rain")]
    [DisplayName("needs_overworld_rain")]
    [Category("その他")]
    [Description("進化条件に天気が関係するか")]
    public required bool NeedsOverworldRain { get; set; }
    #endregion

    #region 進化に必要な手持ちポケモン種族
    /// <summary>
    /// 進化に必要な手持ちポケモン種族
    /// </summary>
    [JsonPropertyName("party_species")]
    [DisplayName("party_species")]
    [Category("手持ちポケモン")]
    [Description("進化に必要な手持ちポケモン種族")]
    public NamedAPIResource? PartySpecies { get; set; }
    #endregion

    #region 進化に必要な手持ちポケモンタイプ
    /// <summary>
    /// 進化に必要な手持ちポケモンタイプ
    /// </summary>
    [JsonPropertyName("party_type")]
    [DisplayName("party_type")]
    [Category("手持ちポケモン")]
    [Description("進化に必要な手持ちポケモンタイプ")]
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
    [DisplayName("relative_physical_stats")]
    [Category("ポケモン")]
    [Description("攻撃と防御の関係性 / 1:攻撃 > 防御 /  0:攻撃 = 防御 / -1:攻撃 < 防御")]
    public int? RelativePhysicalStats { get; set; }
    #endregion

    #region 進化する時間帯
    /// <summary>
    /// 進化する時間帯
    /// </summary>
    [JsonPropertyName("time_of_day")]
    [DisplayName("time_of_day")]
    [Category("その他")]
    [Description("進化する時間帯")]
    public string? TimeOfDay { get; set; }
    #endregion

    #region 交換対象のポケモン種族
    /// <summary>
    /// 交換対象のポケモン種族
    /// </summary>
    [JsonPropertyName("trade_species")]
    [DisplayName("trade_species")]
    [Category("その他")]
    [Description("交換対象のポケモン種族")]
    public NamedAPIResource? TradeSpecies { get; set; }
    #endregion

    #region 進化時にゲーム機を逆さまにする必要があるか
    /// <summary>
    /// 進化時にゲーム機を逆さまにする必要があるか
    /// </summary>
    [JsonPropertyName("turn_upside_down")]
    [DisplayName("turn_upside_down")]
    [Category("その他")]
    [Description("進化時にゲーム機を逆さまにする必要があるか")]
    public bool TurnUpsideDown { get; set; }
    #endregion

    #region 文字列
    /// <summary>
    /// 文字列
    /// </summary>
    [Category("(基本)")]
    [Description("概略テキスト")]
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
