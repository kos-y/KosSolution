using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// 特性
/// </summary>
public class KAbility
{
    /// <summary>
    /// 特性ID
    /// </summary>
    public int ID {  get; set; }

    /// <summary>
    /// 特性名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// メインシリーズか
    /// </summary>
    public bool IsMainSeries { get; set; }

    /// <summary>
    /// 世代
    /// </summary>
    public KNamedAPIResource Generation { get; set; } = new();

    /// <summary>
    /// 特性名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// 効果リスト
    /// </summary>
    public List<KVerboseEffect> EffectEntries { get; set; } = [];

    /// <summary>
    /// 効果の変更歴リスト
    /// </summary>
    public List<KAbilityEffectChange> EffectChanges { get; set; } = [];

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    public List<KAbilityFlavorText> FlavorTextEntries { get; set; } = [];

    /// <summary>
    /// ポケモンリスト
    /// </summary>
    public List<KAbilityPokemon> Pokemon { get; set; } = [];
}
