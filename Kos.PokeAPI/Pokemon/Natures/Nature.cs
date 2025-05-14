using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Natures;

/// <summary>
/// 性格
/// </summary>
public class Nature
{
    /// <summary>
    /// 性格ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("(基本)")]
    [Description("性格ID")]
    public int? Id { get; set; }

    /// <summary>
    /// 性格の名前
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 下降するステータス
    /// </summary>
    public NamedAPIResource? DecreasedStat { get; set; }

    /// <summary>
    /// 上昇するステータス
    /// </summary>
    public NamedAPIResource? IncreasedStat { get; set; }

    /// <summary>
    /// 嫌いなきのみの味
    /// </summary>
    public NamedAPIResource? HatesFlavor { get; set; }

    /// <summary>
    /// 好きなきのみの味
    /// </summary>
    public NamedAPIResource? LikesFlavor { get; set; }

    /// <summary>
    /// 影響を与えるポケスロンのステータス
    /// </summary>
    public IReadOnlyList<NatureStatChange>? PokeathlonStatChange { get; set; }

    /// <summary>
    /// 戦闘スタイル
    /// </summary>
    public IReadOnlyList<MoveBattleStylePreference>? MoveBattleStylePreferences { get; set; }

    /// <summary>
    /// 性格名リスト
    /// </summary>
    public IReadOnlyList<Name>? Names { get; set; }
}
