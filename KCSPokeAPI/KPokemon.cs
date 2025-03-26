using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン
/// </summary>
public class KPokemon
{
    /// <summary>
    /// ポケモンID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// ポケモン名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 基本経験値
    /// </summary>
    public int BaseExperience { get; set; }

    /// <summary>
    /// 高さ
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// 種族の中でデフォルトか
    /// </summary>
    public bool IsDefault { get; set; }

    /// <summary>
    /// 順番
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// 重さ
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// 特性リスト
    /// </summary>
    public List<KPokemonAbility> Abilities { get; set; } = [];

    /// <summary>
    /// リージョンフォームリスト
    /// </summary>
    public List<KNamedAPIResource> Forms { get; set; } = [];

    /// <summary>
    /// バージョンごとのゲームインデックス
    /// </summary>
    public List<KVersionGameIndex> GameIndices { get; set; } = [];

    /// <summary>
    /// もっているアイテムリスト
    /// </summary>
    public List<KPokemonHeldItem> HeldItems { get; set; } = [];

    /// <summary>
    /// エンカウントする場所
    /// </summary>
    public string LocationAreaEncounters { get; set; } = string.Empty;

    /// <summary>
    /// 技リスト
    /// </summary>
    public List<KPokemonMove> Moves { get; set; } = [];

    /// <summary>
    /// 過去のタイプリスト
    /// </summary>
    public List<KPokemonTypePast> PastTypes { get; set; } = [];

    /// <summary>
    /// スプライト
    /// </summary>
    public KPokemonSprites Sprites { get; set; } = new();

    /// <summary>
    /// 鳴き声
    /// </summary>
    public KPokemonCries Cries { get; set; } = new();

    /// <summary>
    /// ステータスリスト
    /// </summary>
    public List<KPokemonStat> Stats { get; set; } = [];

    /// <summary>
    /// タイプリスト
    /// </summary>
    public List<KPokemonType> Types { get; set; } = [];
}
