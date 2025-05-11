using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Abilities;

/// <summary>
/// 特性
/// </summary>
public class Ability
{
    #region 特性ID
    /// <summary>
    /// 特性ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("特性ID")]
    public int? Id { get; set; }
    #endregion

    #region 特性の名前
    /// <summary>
    /// 特性の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("特性の名前")]
    public string? Name { get; set; }
    #endregion

    #region メインシリーズか
    /// <summary>
    /// メインシリーズか
    /// </summary>
    [JsonPropertyName("is_main_series")]
    [DisplayName("is_main_series")]
    [Category("(基本)")]
    [Description("メインシリーズか")]
    public bool? IsMainSeries { get; set; }
    #endregion

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

    #region 言語ごとの名前
    /// <summary>
    /// 言語ごとの名前
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region 言語ごとの効果
    /// <summary>
    /// 言語ごとの効果
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [DisplayName("effect_entries")]
    [Category("(基本)")]
    [Description("言語ごとの効果リスト")]
    [TypeConverter(typeof(ListConverter<VerboseEffect>))]
    public IReadOnlyList<VerboseEffect>? EffectEntries { get; set; }
    #endregion

    #region 効果の変更歴リスト
    /// <summary>
    /// 効果の変更歴リスト
    /// </summary>
    [JsonPropertyName("effect_changes")]
    [DisplayName("effect_changes")]
    [Category("(基本)")]
    [Description("効果の変更歴リスト")]
    [TypeConverter(typeof(ListConverter<AbilityEffectChange>))]
    public IReadOnlyList<AbilityEffectChange>? EffectChanges { get; set; }
    #endregion

    #region フレーバーテキストリスト
    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [DisplayName("flavor_text_entries")]
    [Category("(基本)")]
    [Description("フレーバーテキストリスト")]
    [TypeConverter(typeof(ListConverter<AbilityFlavorText>))]
    public IReadOnlyList<AbilityFlavorText>? FlavorTextEntries { get; set; }
    #endregion

    #region ポケモンリスト
    /// <summary>
    /// ポケモンリスト
    /// </summary>
    [JsonPropertyName("pokemon")]
    [DisplayName("pokemon")]
    [Category("(基本)")]
    [Description("ポケモンリスト")]
    [TypeConverter(typeof(ListConverter<AbilityPokemon>))]
    public IReadOnlyList<AbilityPokemon>? Pokemon { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Ability? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Ability>(json);
    }
    #endregion
}
