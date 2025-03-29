using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// タイプ
/// </summary>
public class KType
{
    /// <summary>
    /// ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// タイプ相性
    /// </summary>
    public KTypeRelations DamageRelations { get; set; } = new();

    /// <summary>
    /// 過去のタイプ相性
    /// </summary>
    public List<KTypeRelationsPast> PastDamageRelations { get; set; } = [];

    /// <summary>
    /// 世代ごとのゲームIndex
    /// </summary>
    public List<KGenerationGameIndex> GameIndices { get; set; } = [];

    /// <summary>
    /// 世代
    /// </summary>
    public KNamedAPIResource Generation { get; set; }

    /// <summary>
    /// 技のダメージ分類
    /// </summary>
    public KNamedAPIResource MoveDamageClass { get; set; }

    /// <summary>
    /// 名前リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// ポケモンタイプリスト
    /// </summary>
    public List<KTypePokemon> Pokemons { get; set; } = [];

    /// <summary>
    /// 技リスト
    /// </summary>
    public List<KNamedAPIResource> Moves { get; set; } = [];
}
