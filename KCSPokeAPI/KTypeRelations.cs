using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// タイプ相性
/// </summary>
public class KTypeRelations
{
    /// <summary>
    /// 攻撃時に無効になるタイプ
    /// </summary>
    public List<KNamedAPIResource> NoDamageTo { get; set; } = [];

    /// <summary>
    /// 攻撃時にいまひとつになるタイプ
    /// </summary>
    public List<KNamedAPIResource> HalfDamageTo { get; set; } = [];

    /// <summary>
    /// 攻撃時に抜群になるタイプ
    /// </summary>
    public List<KNamedAPIResource> DoubleDamageTo { get; set; } = [];

    /// <summary>
    /// 攻撃を受ける時に無効になるタイプ
    /// </summary>
    public List<KNamedAPIResource> NoDamageFrom { get; set; } = [];

    /// <summary>
    /// 攻撃を受けるときにいまひとつになるタイプ
    /// </summary>
    public List<KNamedAPIResource> HalfDamageFrom { get; set; } = [];

    /// <summary>
    /// 攻撃を受けるときに抜群になるタイプ
    /// </summary>
    public List<KNamedAPIResource> DoubleDamageFrom { get; set; } = [];
}
