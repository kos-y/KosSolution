using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// ポケモン図鑑
/// </summary>
public class KPokedex
{
    /// <summary>
    /// ポケモン図鑑ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// ポケモン図鑑名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// メインシリーズか
    /// </summary>
    public bool IsMainSeries { get; set; }

    /// <summary>
    /// 説明リスト
    /// </summary>
    public List<KDescription> Descriptions { get; set; } = [];

    /// <summary>
    /// ポケモン図鑑名リスト
    /// </summary>
    public List<KName> Names { get; set; } = [];

    /// <summary>
    /// ポケモン登録情報リスト
    /// </summary>
    public List<KPokemonEntry> PokemonEntries { get; set; } = [];

    /// <summary>
    /// 地域
    /// </summary>
    public KNamedAPIResource Region { get; set; }

    /// <summary>
    /// バージョングループリスト
    /// </summary>
    public List<KNamedAPIResource> VersionGroups { get; set; } = [];
}
