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
/// 過去のポケモンタイプ
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PokemonTypePast
{
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

    #region タイプリスト
    /// <summary>
    /// タイプリスト
    /// </summary>
    [JsonPropertyName("types")]
    [DisplayName("types")]
    [Category("(基本)")]
    [Description("タイプリスト")]
    public IReadOnlyList<PokemonType>? Types { get; set; }
    #endregion
}
