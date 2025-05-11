using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Pokemon.Abilities;
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
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("技ID")]
    public int? Id { get; set; }
    #endregion

    #region 技の名前
    /// <summary>
    /// 技の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("技の名前")]
    public string? Name { get; set; }
    #endregion

    #region 命中率
    /// <summary>
    /// 命中率
    /// </summary>
    [JsonPropertyName("accurary")]
    [DisplayName("accurary")]
    [Category("(基本)")]
    [Description("命中率")]
    public int? Accurary { get; set; }
    #endregion

    #region 追加効果の発生確率
    /// <summary>
    /// 追加効果の発生確率
    /// </summary>
    [JsonPropertyName("effect_chance")]
    [DisplayName("effect_chance")]
    [Category("(基本)")]
    [Description("追加効果の発生確率")]
    public int? EffectChance { get; set; }
    #endregion

    #region 消費PP
    /// <summary>
    /// 消費PP
    /// </summary>
    [JsonPropertyName("pp")]
    [DisplayName("pp")]
    [Category("(基本)")]
    [Description("消費PP")]
    public int? PP { get; set; }
    #endregion

    #region 技の発動順番
    /// <summary>
    /// 技の発動順番
    /// </summary>
    [JsonPropertyName("priority")]
    [DisplayName("priority")]
    [Category("(基本)")]
    [Description("技の発動順番")]
    public int? Priority { get; set; }
    #endregion

    #region 威力
    /// <summary>
    /// 威力
    /// </summary>
    [JsonPropertyName("power")]
    [DisplayName("power")]
    [Category("(基本)")]
    [Description("威力")]
    public int? Power { get; set; }
    #endregion

    #region コンテストの技コンボ
    /// <summary>
    /// コンテストの技コンポ
    /// </summary>
    [JsonPropertyName("contest_combos")]
    [DisplayName("contest_combos")]
    [Category("コンテスト")]
    [Description("コンテストの技コンボ")]
    public ContestComboSets? ContestCombos { get; set; }
    #endregion

    #region コンテストの種類
    /// <summary>
    /// コンテストの種類
    /// </summary>
    [JsonPropertyName("contest_type")]
    [DisplayName("contest_type")]
    [Category("コンテスト")]
    [Description("コンテストの種類")]
    public NamedAPIResource? ContestType { get; set; }
    #endregion

    #region コンテストで使用した場合の効果
    /// <summary>
    /// コンテストで使用した場合の効果
    /// </summary>
    [JsonPropertyName("contest_effect")]
    [DisplayName("contest_effect")]
    [Category("コンテスト")]
    [Description("コンテストで使用した場合の効果")]
    public NamedAPIResource? ContestEffect { get; set; }
    #endregion

    #region ダメージの種類
    /// <summary>
    /// ダメージの種類
    /// </summary>
    [JsonPropertyName("damage_class")]
    [DisplayName("damage_class")]
    [Category("(基本)")]
    [Description("ダメージの種類")]
    public NamedAPIResource? DamageClass { get; set; }
    #endregion

    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [DisplayName("effect_entries")]
    [Category("効果")]
    [Description("効果リスト")]
    [TypeConverter(typeof(ListConverter<VerboseEffect>))]
    public IReadOnlyList<VerboseEffect>? EffectEntries { get; set; }
    #endregion

    #region 効果変更リスト
    /// <summary>
    /// 効果変更リスト
    /// </summary>
    [JsonPropertyName("effect_changes")]
    [DisplayName("effect_changes")]
    [Category("効果")]
    [Description("効果変更リスト")]
    [TypeConverter(typeof(ListConverter<AbilityEffectChange>))]
    public IReadOnlyList<AbilityEffectChange>? EffectChanges { get; set; }
    #endregion

    #region 習得するポケモンリスト
    /// <summary>
    /// 習得するポケモンリスト
    /// </summary>
    [JsonPropertyName("learned_by_pokemon")]
    [DisplayName("learned_by_pokemon")]
    [Category("(基本)")]
    [Description("習得するポケモンリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? LearnedByPokemon { get; set; }
    #endregion

    #region 技のフレーバーテキストリスト
    /// <summary>
    /// 技のフレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [DisplayName("flavor_text_entries")]
    [Category("(基本)")]
    [Description("技のフレーバーテキストリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<MoveFlavorText>? FlavorTextEntries { get; set; }
    #endregion

    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    [DisplayName("generation")]
    [Category("(基本)")]
    [Description("世代")]
    public NamedAPIResource? Generation { get; set; }
    #endregion

    #region 技マシンリスト
    /// <summary>
    /// 技マシンリスト
    /// </summary>
    [JsonPropertyName("machines")]
    [DisplayName("machines")]
    [Category("(基本)")]
    [Description("技マシンリスト")]
    [TypeConverter(typeof(ListConverter<MachineVersionDetail>))]
    public IReadOnlyList<MachineVersionDetail>? Machines { get; set; }
    #endregion

    #region 詳細データ
    /// <summary>
    /// 詳細データ
    /// </summary>
    [JsonPropertyName("meta")]
    [DisplayName("meta")]
    [Category("(基本)")]
    [Description("詳細データ")]
    public MoveMetaData? Meta { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region 過去のステータス変化値
    /// <summary>
    /// 過去のステータス変化値
    /// </summary>
    [JsonPropertyName("past_values")]
    [DisplayName("past_values")]
    [Category("(基本)")]
    [Description("過去のステータス変化値")]
    [TypeConverter(typeof(ListConverter<PastMoveStatValues>))]
    public IReadOnlyList<PastMoveStatValues>? PastValues { get; set; }
    #endregion

    #region ステータスに影響を与えるリスト
    /// <summary>
    /// ステータスに影響を与えるリスト
    /// </summary>
    [JsonPropertyName("stat_changes")]
    [DisplayName("stat_changes")]
    [Category("(基本)")]
    [Description("ステータスに影響を与えるリスト")]
    [TypeConverter(typeof(ListConverter<PastMoveStatValues>))]
    public IReadOnlyList<MoveStatChange>? StatChanges { get; set; }
    #endregion

    #region スーパーコンテストの効果
    /// <summary>
    /// スーパーコンテストの効果
    /// </summary>
    [JsonPropertyName("super_contest_effect")]
    [DisplayName("super_contest_effect")]
    [Category("コンテスト")]
    [Description("スーパーコンテストの効果")]
    public NamedAPIResource? SuperContestEffect { get; set; }
    #endregion

    #region 対象
    /// <summary>
    /// 対象
    /// </summary>
    [JsonPropertyName("target")]
    [DisplayName("target")]
    [Category("(基本)")]
    [Description("対象")]
    public NamedAPIResource? Target { get; set; }
    #endregion

    #region 技タイプ
    /// <summary>
    /// 技タイプ
    /// </summary>
    [JsonPropertyName("type")]
    [DisplayName("type")]
    [Category("(基本)")]
    [Description("技タイプ")]
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
