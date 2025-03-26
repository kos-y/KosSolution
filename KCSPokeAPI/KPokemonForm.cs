using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン リージョンフォーム
/// </summary>
public class KPokemonForm
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
    /// 順番
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// フォーム順番
    /// </summary>
    public int FormOrder { get; set; }

    /// <summary>
    /// デフォルトフォーム
    /// </summary>
    public bool IsDefault { get; set; }

    /// <summary>
    /// 戦闘時のみ
    /// </summary>
    public bool IsBattleOnly { get; set; }

    /// <summary>
    /// メガシンカ
    /// </summary>
    public bool IsMega { get; set; }

    /// <summary>
    /// フォームの名前
    /// </summary>
    public string FormName { get; set; } = string.Empty;

    /// <summary>
    /// ポケモン
    /// </summary>
    public KNamedAPIResource Pokemon { get; set; } = new();

    /// <summary>
    /// タイプリスト
    /// </summary>
    public List<KPokemonFormType> Types { get; set; } = [];

    /// <summary>
    /// スプライト
    /// </summary>
    public KPokemonFormSprites Sprites { get; set; } = new();

    /// <summary>
    /// バージョングループ
    /// </summary>
    public KNamedAPIResource VersionGroup { get; set; } = new();

    /// <summary>
    /// 名前リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// フォームの名前リスト
    /// </summary>
    public List<KName> FormNames { get; set; } = [];
}
