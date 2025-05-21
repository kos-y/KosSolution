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
/// タイプ
/// </summary>
public class Type
{
    #region タイプID
    /// <summary>
    /// タイプID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("タイプ")]
    [Description("タイプID")]
    public int? Id { get; set; }
    #endregion

    #region タイプ名前
    /// <summary>
    /// タイプ名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("タイプ")]
    [Description("タイプ名前")]
    public string? Name { get; set; }
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

    #region 過去のタイプ相性
    /// <summary>
    /// 過去のタイプ相性
    /// </summary>
    [JsonPropertyName("past_damage_relations")]
    [DisplayName("past_damage_relations")]
    [Category("タイプ")]
    [Description("過去のタイプ相性")]
    public IReadOnlyList<TypeRelationsPast>? PastDamageRelations { get; set; }
    #endregion

    #region ゲーム内のIndexリスト
    /// <summary>
    /// ゲーム内のIndexリスト
    /// </summary>
    [JsonPropertyName("game_indices")]
    [DisplayName("game_indices")]
    [Category("タイプ")]
    [Description("ゲーム内のIndexリスト")]
    public IReadOnlyList<GenerationGameIndex>? GameIndices { get; set; }
    #endregion

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

    #region 技のダメージ分類
    /// <summary>
    /// 技のダメージ分類
    /// </summary>
    [JsonPropertyName("move_damage_class")]
    [DisplayName("move_damage_class")]
    [Category("タイプ")]
    [Description("技のダメージ分類")]
    public NamedAPIResource? MoveDamageClass { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("タイプ")]
    [Description("言語ごとの名前リスト")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region ポケモンリスト
    /// <summary>
    /// ポケモンリスト
    /// </summary>
    [JsonPropertyName("pokemons")]
    [DisplayName("pokemons")]
    [Category("タイプ")]
    [Description("ポケモンリスト")]
    public IReadOnlyList<TypePokemon>? Pokemons { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    [DisplayName("moves")]
    [Category("タイプ")]
    [Description("技リスト")]
    public IReadOnlyList<NamedAPIResource>? Moves { get; set; }
    #endregion
}
