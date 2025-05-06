using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// 技がもつ過去のステータス値
/// </summary>
public class PastMoveStatValues
{
    #region 命中率
    /// <summary>
    /// 命中率
    /// </summary>
    [JsonPropertyName("accuracy")]
    public int? Accuracy { get; set; }
    #endregion

    #region 効果が発生する確率
    /// <summary>
    /// 効果が発生する確率
    /// </summary>
    [JsonPropertyName("effect_chance")]
    public int? EffectChance { get; set; }
    #endregion

    #region 威力
    /// <summary>
    /// 威力
    /// </summary>
    [JsonPropertyName("power")]
    public int? Power { get; set; }
    #endregion

    #region 消費PP
    /// <summary>
    /// 消費PP
    /// </summary>
    [JsonPropertyName("pp")]
    public int? PP { get; set; }
    #endregion

    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    public List<VerboseEffect>? EffectEntries { get; set; }
    #endregion

    #region 技タイプ
    /// <summary>
    /// 技タイプ
    /// </summary>
    [JsonPropertyName("type")]
    public NamedAPIResource? Type { get; set; }
    #endregion

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion
}
