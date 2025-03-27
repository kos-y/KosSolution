using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// アイテム
/// </summary>
public class KItem
{
    /// <summary>
    /// アイテムID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// アイテム名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 価格
    /// </summary>
    public int Cost { get; set; }

    /// <summary>
    /// なげつけるの威力
    /// </summary>
    public int FlingPower { get; set; }

    /// <summary>
    /// なげつけるの効果
    /// </summary>
    public KNamedAPIResource FlingEffect { get; set; } = new();

    /// <summary>
    /// アイテムを持っていることによる特性
    /// </summary>
    public List<KNamedAPIResource> Attributes { get; set; } = [];

    /// <summary>
    /// カテゴリ
    /// </summary>
    public KNamedAPIResource Category { get; set; } = new();

    /// <summary>
    /// 効果リスト
    /// </summary>
    public List<KVerboseEffect> EffectEntries { get; set; } = [];

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    public List<KVersionGroupFlavorText> FlavorTextEntries { get; set; } = [];

    /// <summary>
    /// 世代毎のリスト
    /// </summary>
    public List<KGenerationGameIndex> GameIndice { get; set; } = [];

    /// <summary>
    /// アイテム名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// スプライト
    /// </summary>
    public KItemSprites Sprites { get; set; } = new();

    /// <summary>
    /// 所持ポケモンリスト
    /// </summary>
    public List<KItemHolderPokemon> HeldByPokemon { get; set; } = [];

    /// <summary>
    /// ベビーポケモンの進化トリガー
    /// </summary>
    public required KAPIResource BabyTriggerFor { get; set; }

    /// <summary>
    /// 技マシンリスト
    /// </summary>
    public List<KMachineVersionDetail> Machines { get; set; } = [];
}
