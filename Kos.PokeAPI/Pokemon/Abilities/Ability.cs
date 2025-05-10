using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Abilities;

/// <summary>
/// 特性
/// </summary>
public class Ability
{
    #region 特性ID
    /// <summary>
    /// 特性ID
    /// </summary>
    public int? Id { get; set; }
    #endregion

    #region 特性名
    /// <summary>
    /// 特性名
    /// </summary>
    public string? Name { get; set; }
    #endregion

    #region メインシリーズか
    /// <summary>
    /// メインシリーズか
    /// </summary>
    public bool? IsMainSeries { get; set; }
    #endregion

    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    public NamedAPIResource? Generation { get; set; }
    #endregion

    #region 言語ごとの名前
    /// <summary>
    /// 言語ごとの名前
    /// </summary>
    public List<Name>? Names { get; set; }
    #endregion

    #region 言語ごとの効果
    /// <summary>
    /// 言語ごとの効果
    /// </summary>
    public List<VerboseEffect>? EffectEntries { get; set; }
    #endregion

    #region 効果の変更歴リスト
    /// <summary>
    /// 効果の変更歴リスト
    /// </summary>
    public List<AbilityEffectChange>? EffectChanges { get; set; }
    #endregion

    #region フレーバーテキストリスト
    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    public List<AbilityFlavorText>? FlavorTextEntries { get; set; }
    #endregion

    #region ポケモンリスト
    /// <summary>
    /// ポケモンリスト
    /// </summary>
    public List<AbilityPokemon>? Pokemon { get; set; }
    #endregion
}
