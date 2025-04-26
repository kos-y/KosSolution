using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Items.Item;

/// <summary>
/// アイテム
/// </summary>
public class Item
{
    /// <summary>
    /// アイテムID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// アイテム名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 価格
    /// </summary>
    [JsonPropertyName("cost")]
    public int? Cost { get; set; }

    /// <summary>
    /// なげつけるの威力
    /// </summary>
    [JsonPropertyName("fling_power")]
    public int? FlingPower { get; set; }

    /// <summary>
    /// なげつけるの効果
    /// </summary>
    [JsonPropertyName("fling_effect")]
    public NamedAPIResource? FlingEffect { get; set; }

    /// <summary>
    /// アイテムを持っていることによる特性
    /// </summary>
    [JsonPropertyName("attributes")]
    public List<NamedAPIResource>? Attributes { get; set; }

    /// <summary>
    /// カテゴリ
    /// </summary>
    [JsonPropertyName("category")]
    public NamedAPIResource? Category { get; set; }

    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    public List<VerboseEffect>? EffectEntries { get; set; }

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    public List<VersionGroupFlavorText>? FlavorTextEntries { get; set; }

    /// <summary>
    /// 世代毎のリスト
    /// </summary>
    [JsonPropertyName("game_indices")]
    public List<GenerationGameIndex>? GameIndice { get; set; }

    /// <summary>
    /// アイテム名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }

    /// <summary>
    /// スプライト
    /// </summary>
    [JsonPropertyName("sprites")]
    public ItemSprites? Sprites { get; set; }

    /// <summary>
    /// 所持ポケモンリスト
    /// </summary>
    [JsonPropertyName("held_by_pokemon")]
    public List<ItemHolderPokemon>? HeldByPokemon { get; set; }

    /// <summary>
    /// ベビーポケモンの進化トリガー
    /// </summary>
    [JsonPropertyName("baby_trigger_for")]
    public APIResource? BabyTriggerFor { get; set; }

    /// <summary>
    /// 技マシンリスト
    /// </summary>
    [JsonPropertyName("machines")]
    public List<MachineVersionDetail>? Machines { get; set; }


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
}
