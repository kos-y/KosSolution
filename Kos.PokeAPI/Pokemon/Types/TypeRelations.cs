using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Types;

/// <summary>
/// タイプ相性
/// </summary>
public class TypeRelations
{
    #region 攻撃時に無効になるタイプ
    /// <summary>
    /// 攻撃時に無効になるタイプ
    /// </summary>
    [JsonPropertyName("no_damage_to")]
    [DisplayName("no_damage_to")]
    [Category("タイプ")]
    [Description("攻撃時に無効になるタイプ")]
    public IReadOnlyList<NamedAPIResource>? NoDamageTo { get; set; }
    #endregion

    #region 攻撃時にいまひとつになるタイプ
    /// <summary>
    /// 攻撃時にいまひとつになるタイプ
    /// </summary>
    [JsonPropertyName("half_damage_to")]
    [DisplayName("half_damage_to")]
    [Category("タイプ")]
    [Description("攻撃時にいまひとつになるタイプ")]
    public IReadOnlyList<NamedAPIResource>? HalfDamageTo { get; set; }
    #endregion

    #region 攻撃時に抜群になるタイプ
    /// <summary>
    /// 攻撃時に抜群になるタイプ
    /// </summary>
    [JsonPropertyName("double_damage_to")]
    [DisplayName("double_damage_to")]
    [Category("タイプ")]
    [Description("攻撃時に抜群になるタイプ")]
    public IReadOnlyList<NamedAPIResource>? DoubleDamageTo { get; set; }
    #endregion

    #region 攻撃を受ける時に無効になるタイプ
    /// <summary>
    /// 攻撃を受ける時に無効になるタイプ
    /// </summary>
    [JsonPropertyName("no_damage_from")]
    [DisplayName("no_damage_from")]
    [Category("タイプ")]
    [Description("攻撃を受ける時に無効になるタイプ")]
    public IReadOnlyList<NamedAPIResource>? NoDamageFrom { get; set; }
    #endregion

    #region 攻撃を受けるときにいまひとつになるタイプ
    /// <summary>
    /// 攻撃を受けるときにいまひとつになるタイプ
    /// </summary>
    [JsonPropertyName("half_damage_from")]
    [DisplayName("half_damage_from")]
    [Category("タイプ")]
    [Description("攻撃を受けるときにいまひとつになるタイプ")]
    public IReadOnlyList<NamedAPIResource>? HalfDamageFrom { get; set; }
    #endregion

    #region 攻撃を受けるときに抜群になるタイプ
    /// <summary>
    /// 攻撃を受けるときに抜群になるタイプ
    /// </summary>
    [JsonPropertyName("double_damage_from")]
    [DisplayName("double_damage_from")]
    [Category("タイプ")]
    [Description("攻撃を受けるときに抜群になるタイプ")]
    public IReadOnlyList<NamedAPIResource>? DoubleDamageFrom { get; set; }
    #endregion
}
