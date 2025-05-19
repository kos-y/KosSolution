using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Pokemon;

/// <summary>
/// ポケモンが覚える技 バージョンごと
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonMoveVersion
{
    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    [DisplayName("version_group")]
    [Category("(基本)")]
    [Description("バージョングループ")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion

    #region 技の習得方法
    /// <summary>
    /// 技の習得方法
    /// </summary>
    [JsonPropertyName("move_learn_method")]
    [DisplayName("move_learn_method")]
    [Category("(基本)")]
    [Description("技の習得方法")]
    public NamedAPIResource? MoveLearnMethod { get; set; }
    #endregion

    #region 習得最低レベル
    /// <summary>
    /// 習得最低レベル
    /// </summary>
    [JsonPropertyName("level_learned_at")]
    [DisplayName("level_learned_at")]
    [Category("(基本)")]
    [Description("週九最低レベル")]
    public int? LevelLearnedAt { get; set; }
    #endregion
}
