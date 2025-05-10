using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;
using System.ComponentModel;
using Kos.Core;

namespace Kos.PokeAPI.Items.Item;

/// <summary>
/// アイテム
/// </summary>
public class Item
{
    #region アイテムID
    /// <summary>
    /// アイテムID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("アイテムID")]
    public int? Id { get; set; }
    #endregion

    #region アイテムの名前
    /// <summary>
    /// アイテムの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("アイテムの名前")]
    public string? Name { get; set; }
    #endregion

    #region 価格
    /// <summary>
    /// 価格
    /// </summary>
    [JsonPropertyName("cost")]
    [DisplayName("cost")]
    [Category("(基本)")]
    [Description("価格")]
    public int? Cost { get; set; }
    #endregion

    #region なげつけるの威力
    /// <summary>
    /// なげつけるの威力
    /// </summary>
    [JsonPropertyName("fling_power")]
    [DisplayName("fling_power")]
    [Category("なげつける")]
    [Description("なげつけるの威力")]
    public int? FlingPower { get; set; }
    #endregion

    #region なげつけるの効果
    /// <summary>
    /// なげつけるの効果
    /// </summary>
    [JsonPropertyName("fling_effect")]
    [DisplayName("fling_effect")]
    [Category("なげつける")]
    [Description("なげつけるの効果")]
    public NamedAPIResource? FlingEffect { get; set; }
    #endregion

    #region アイテムを持っていることによる特性
    /// <summary>
    /// アイテムを持っていることによる特性
    /// </summary>
    [JsonPropertyName("attributes")]
    [DisplayName("attributes")]
    [Category("(基本)")]
    [Description("アイテムを持っていることによる特性")]
    public IReadOnlyList<NamedAPIResource>? Attributes { get; set; }
    #endregion

    #region カテゴリ
    /// <summary>
    /// カテゴリ
    /// </summary>
    [JsonPropertyName("category")]
    [DisplayName("category")]
    [Category("(基本)")]
    [Description("カテゴリ")]
    public NamedAPIResource? Category { get; set; }
    #endregion

    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [DisplayName("effect_entries")]
    [Category("(基本)")]
    [Description("効果リスト")]
    [TypeConverter(typeof(ListConverter<VerboseEffect>))]
    public IReadOnlyList<VerboseEffect>? EffectEntries { get; set; }
    #endregion

    #region フレーバーテキストリスト
    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [DisplayName("flavor_text_entries")]
    [Category("(基本)")]
    [Description("フレーバーテキストリスト")]
    [TypeConverter(typeof(ListConverter<VersionGroupFlavorText>))]
    public IReadOnlyList<VersionGroupFlavorText>? FlavorTextEntries { get; set; }
    #endregion

    #region 世代毎のリスト
    /// <summary>
    /// 世代毎のリスト
    /// </summary>
    [JsonPropertyName("game_indices")]
    [DisplayName("game_indices")]
    [Category("(基本)")]
    [Description("世代毎のリスト")]
    [TypeConverter(typeof(ListConverter<GenerationGameIndex>))]
    public IReadOnlyList<GenerationGameIndex>? GameIndice { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region スプライト
    /// <summary>
    /// スプライト
    /// </summary>
    [JsonPropertyName("sprites")]
    [DisplayName("sprites")]
    [Category("(基本)")]
    [Description("スプライト")]
    public ItemSprites? Sprites { get; set; }
    #endregion

    #region 所持ポケモンリスト
    /// <summary>
    /// 所持ポケモンリスト
    /// </summary>
    [JsonPropertyName("held_by_pokemon")]
    [DisplayName("held_by_pokemon")]
    [Category("(基本)")]
    [Description("所持ポケモンリスト")]
    [TypeConverter(typeof(ListConverter<ItemHolderPokemon>))]
    public IReadOnlyList<ItemHolderPokemon>? HeldByPokemon { get; set; }
    #endregion

    #region ベビーポケモンの進化トリガー
    /// <summary>
    /// ベビーポケモンの進化トリガー
    /// </summary>
    [JsonPropertyName("baby_trigger_for")]
    [DisplayName("baby_trigger_for")]
    [Category("(基本)")]
    [Description("ベビーポケモンの進化トリガー")]
    public APIResource? BabyTriggerFor { get; set; }
    #endregion

    #region 技マシンリスト
    /// <summary>
    /// 技マシンリスト
    /// </summary>
    [JsonPropertyName("machines")]
    [DisplayName("machines")]
    [Category("(基本)")]
    [Description("技マシンリスト")]
    [TypeConverter(typeof(ListConverter<MachineVersionDetail>))]
    public IReadOnlyList<MachineVersionDetail>? Machines { get; set; }
    #endregion


    // リソース

    #region アイテムリソースの取得
    /// <summary>
    /// アイテムリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>アイテムリソース</returns>
    public static Item? GetItem(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Item>(json);
    }
    #endregion
}
