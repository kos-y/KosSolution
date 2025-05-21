using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Pokemon.PokeathlonStats;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Stats;

/// <summary>
/// ステータス
/// </summary>
public class Stat
{
    #region ステータスID
    /// <summary>
    /// ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("ステータス")]
    [Description("ステータスID")]
    public int? Id { get; set; }
    #endregion

    #region ステータスの名前
    /// <summary>
    /// 名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("ステータス")]
    [Description("ステータスの名前")]
    public string? Name { get; set; }
    #endregion

    #region ゲーム内のIndex
    /// <summary>
    /// ゲームIndex
    /// </summary>
    [JsonPropertyName("game_index")]
    [DisplayName("game_index")]
    [Category("ステータス")]
    [Description("ゲーム内のIndex")]
    public int? GameIndex { get; set; }
    #endregion

    #region 戦闘時だけのステータスかどうか
    /// <summary>
    /// 戦闘時のみか
    /// </summary>
    [JsonPropertyName("is_battle_only")]
    [DisplayName("is_battle_only")]
    [Category("ステータス")]
    [Description("戦闘時だけのステータスかどうか")]
    public bool? IsBattleOnly { get; set; }
    #endregion

    #region ステータスに影響を与える技
    /// <summary>
    /// 影響を与える技
    /// </summary>
    [JsonPropertyName("affecting_moves")]
    [DisplayName("affecting_moves")]
    [Category("ステータス")]
    [Description("ステータスに影響を与える技")]
    public MoveStatAffectSets? AffectingMoves { get; set; }
    #endregion

    #region ステータスに影響を与える性格
    /// <summary>
    /// 影響を与える性格
    /// </summary>
    [JsonPropertyName("affecting_natures")]
    [DisplayName("affecting_natures")]
    [Category("ステータス")]
    [Description("ステータスに影響を与える性格")]
    public NaturePokeathlonStatAffectSets? AffectingNatures { get; set; }
    #endregion

    #region 個性リスト
    /// <summary>
    /// 個性リスト
    /// </summary>
    [JsonPropertyName("characteristics")]
    [DisplayName("characteristics")]
    [Category("ステータス")]
    [Description("個性リスト")]
    public IReadOnlyList<NamedAPIResource>? Characteristics { get; set; }
    #endregion

    #region 技のダメージ分類
    /// <summary>
    /// 技のダメージ分類
    /// </summary>
    [JsonPropertyName("move_damage_class")]
    [DisplayName("move_damage_class")]
    [Category("ステータス")]
    [Description("技のダメージ分類")]
    public NamedAPIResource? MoveDamageClass { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("ステータス")]
    [Description("言語ごとの名前リスト")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion
}
