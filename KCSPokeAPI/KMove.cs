using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 技
/// </summary>
public class KMove
{
    /// <summary>
    /// 技ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 技名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 命中率
    /// </summary>
    public int Accurary { get; set; }

    /// <summary>
    /// 追加効果の発生確率
    /// </summary>
    public int EffectChange { get; set; }

    /// <summary>
    /// 消費PP
    /// </summary>
    public int PP { get; set; }

    /// <summary>
    /// 技の発動順番
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// 威力
    /// </summary>
    public int Power { get; set; }

    /// <summary>
    /// コンテストの技コンポ
    /// </summary>
    public KContestComboSets ContestCombos { get; set; } = new();

    /// <summary>
    /// コンテストのタイプ
    /// </summary>
    public KNamedAPIResource ContestType { get; set; } = new();

    /// <summary>
    /// コンテストで使用した場合の効果
    /// </summary>
    public KNamedAPIResource ContestEffect { get; set; } = new();

    /// <summary>
    /// ダメージの種類
    /// </summary>
    public KNamedAPIResource DamageClass { get; set; } = new();

    /// <summary>
    /// 効果リスト
    /// </summary>
    public List<KVerboseEffect> EffectEntries { get; set; } = [];

    /// <summary>
    /// 習得するポケモンリスト
    /// </summary>
    public List<KNamedAPIResource> LearnedByPokemon { get; set; } = [];

    /// <summary>
    /// 技のフレーバーテキストリスト
    /// </summary>
    public List<KMoveFlavorText> FlavorTextEntries { get; set; } = [];

    /// <summary>
    /// 世代
    /// </summary>
    public KNamedAPIResource Generation { get; set; } = new();

    /// <summary>
    /// 技マシンリスト
    /// </summary>
    public List<KMachineVersionDetail> Machines { get; set; } = new();

    /// <summary>
    /// メタデータ
    /// </summary>
    public KMoveMetaData Meta { get; set; } = new();

    /// <summary>
    /// 技名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// 過去の値
    /// </summary>
    public List<KPastMoveStatValues> PastValues { get; set; } = [];

    /// <summary>
    /// ステータスに影響を与えるリスト
    /// </summary>
    public List<KMoveStatChange> StateChanges { get; set; } = [];

    /// <summary>
    /// スーパーコンテストの効果
    /// </summary>
    public KNamedAPIResource SuperContestEffect { get; set; } = new();

    /// <summary>
    /// 対象
    /// </summary>
    public KNamedAPIResource Target { get; set; } = new();

    /// <summary>
    /// 技タイプ
    /// </summary>
    public KNamedAPIResource Type { get; set; } = new();
}
