using System.Text.Json;
using System.Text.Json.Serialization;

namespace KCSPokeAPI;

/// <summary>
/// アイテム
/// </summary>
public class KItem
{
    /// <summary>
    /// アイテムID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// アイテム名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 価格
    /// </summary>
    [JsonPropertyName("cost")]
    public required int Cost { get; set; }

    /// <summary>
    /// なげつけるの威力
    /// </summary>
    [JsonPropertyName("fling_power")]
    public required int? FlingPower { get; set; }

    /// <summary>
    /// なげつけるの効果
    /// </summary>
    [JsonPropertyName("fling_effect")]
    public required KNamedAPIResource? FlingEffect { get; set; }

    /// <summary>
    /// アイテムを持っていることによる特性
    /// </summary>
    [JsonPropertyName("attributes")]
    public required List<KNamedAPIResource> Attributes { get; set; }

    /// <summary>
    /// カテゴリ
    /// </summary>
    [JsonPropertyName("category")]
    public required KNamedAPIResource Category { get; set; }

    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    public required List<KVerboseEffect> EffectEntries { get; set; }

    /// <summary>
    /// フレーバーテキストリスト
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    public required List<KVersionGroupFlavorText> FlavorTextEntries { get; set; }

    /// <summary>
    /// 世代毎のリスト
    /// </summary>
    [JsonPropertyName("game_indices")]
    public required List<KGenerationGameIndex> GameIndice { get; set; }

    /// <summary>
    /// アイテム名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public required List<KName> Names { get; set; }

    /// <summary>
    /// スプライト
    /// </summary>
    [JsonPropertyName("sprites")]
    public required KItemSprites Sprites { get; set; }

    /// <summary>
    /// 所持ポケモンリスト
    /// </summary>
    [JsonPropertyName("held_by_pokemon")]
    public required List<KItemHolderPokemon> HeldByPokemon { get; set; }

    /// <summary>
    /// ベビーポケモンの進化トリガー
    /// </summary>
    [JsonPropertyName("baby_trigger_for")]
    public required KAPIResource BabyTriggerFor { get; set; }

    /// <summary>
    /// 技マシンリスト
    /// </summary>
    [JsonPropertyName("machines")]
    public required List<KMachineVersionDetail> Machines { get; set; }


    /// <summary>
    /// アイテムリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>アイテムリソース</returns>
    /// <exception cref="Exception"></exception>
    public static KItem GetItem(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KItem>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
