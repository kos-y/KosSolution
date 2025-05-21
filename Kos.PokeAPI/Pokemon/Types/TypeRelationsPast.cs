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
/// 過去のタイプ相性
/// </summary>
public class TypeRelationsPast
{
    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    [DisplayName("generation")]
    [Category("タイプ")]
    [Description("世代")]
    public NamedAPIResource? Generation { get; set; }
    #endregion

    #region タイプ相性
    /// <summary>
    /// タイプ相性
    /// </summary>
    [JsonPropertyName("damage_relations")]
    [DisplayName("damage_relations")]
    [Category("タイプ")]
    [Description("タイプ相性")]
    public TypeRelations? DamageRelations { get; set; }
    #endregion
}
