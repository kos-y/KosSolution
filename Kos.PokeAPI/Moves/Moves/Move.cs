using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// 技
/// </summary>
public class Move
{
    #region 技ID
    /// <summary>
    /// 技ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 技名
    /// <summary>
    /// 技名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 命中率
    /// <summary>
    /// 命中率
    /// </summary>
    [JsonPropertyName("accurary")]
    public int? Accurary { get; set; }
    #endregion

    #region 追加効果の発生確率
    /// <summary>
    /// 追加効果の発生確率
    /// </summary>
    [JsonPropertyName("effect_chance")]
    public int? EffectChance { get; set; }
    #endregion

    #region 消費PP
    /// <summary>
    /// 消費PP
    /// </summary>
    [JsonPropertyName("pp")]
    public int? PP { get; set; }
    #endregion

    #region 技の発動順番
    /// <summary>
    /// 技の発動順番
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
    #endregion

    #region 威力
    /// <summary>
    /// 威力
    /// </summary>
    [JsonPropertyName("power")]
    public int? Power { get; set; }
    #endregion

    #region コンテストの技コンボ
    /// <summary>
    /// コンテストの技コンポ
    /// </summary>
    [JsonPropertyName("contest_combos")]
    public ContestComboSets? ContestCombos { get; set; }
    #endregion

    #region コンテストの種類
    /// <summary>
    /// コンテストの種類
    /// </summary>
    [JsonPropertyName("contest_type")]
    public NamedAPIResource? ContestType { get; set; }
    #endregion

    #region コンテストで使用した場合の効果
    /// <summary>
    /// コンテストで使用した場合の効果
    /// </summary>
    [JsonPropertyName("contest_effect")]
    public NamedAPIResource? ContestEffect { get; set; }
    #endregion

    #region ダメージの種類
    /// <summary>
    /// ダメージの種類
    /// </summary>
    [JsonPropertyName("damage_class")]
    public NamedAPIResource? DamageClass { get; set; }
    #endregion

    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    public List<VerboseEffect>? EffectEntries { get; set; }
    #endregion

//    public List<>

    #region 習得するポケモンリスト
    /// <summary>
    /// 習得するポケモンリスト
    /// </summary>
    [JsonPropertyName("learned_by_pokemon")]
    public List<NamedAPIResource>? LearnedByPokemon { get; set; }
    #endregion

    #region 技のフレーバーテキストリスト
    /// <summary>
    /// 技のフレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    public List<MoveFlavorText>? FlavorTextEntries { get; set; }
    #endregion

    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    public NamedAPIResource? Generation { get; set; }
    #endregion

    #region 技マシンリスト
    /// <summary>
    /// 技マシンリスト
    /// </summary>
    [JsonPropertyName("machines")]
    public List<MachineVersionDetail>? Machines { get; set; }
    #endregion

    #region 詳細データ
    /// <summary>
    /// 詳細データ
    /// </summary>
    [JsonPropertyName("meta")]
    public MoveMetaData? Meta { get; set; }
    #endregion

    #region 技名リスト
    /// <summary>
    /// 技名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region 過去のステータス変化値
    /// <summary>
    /// 過去のステータス変化値
    /// </summary>
    [JsonPropertyName("past_values")]
    public List<PastMoveStatValues>? PastValues { get; set; }
    #endregion

    #region ステータスに影響を与えるリスト
    /// <summary>
    /// ステータスに影響を与えるリスト
    /// </summary>
    [JsonPropertyName("stat_changes")]
    public List<MoveStatChange>? StatChanges { get; set; }
    #endregion

    #region スーパーコンテストの効果
    /// <summary>
    /// スーパーコンテストの効果
    /// </summary>
    [JsonPropertyName("super_contest_effect")]
    public NamedAPIResource? SuperContestEffect { get; set; }
    #endregion

    #region 対象
    /// <summary>
    /// 対象
    /// </summary>
    [JsonPropertyName("target")]
    public NamedAPIResource? Target { get; set; }
    #endregion

    #region 技タイプ
    /// <summary>
    /// 技タイプ
    /// </summary>
    [JsonPropertyName("type")]
    public NamedAPIResource? Type { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Move? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Move>(json);
    }
    #endregion
}
