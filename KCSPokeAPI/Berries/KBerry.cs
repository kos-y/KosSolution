using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// きのみ
/// </summary>
public class KBerry
{
    /// <summary>
    /// きのみID
    /// </summary>
    [JsonPropertyName("id")]
    public required int ID { get; set; }

    /// <summary>
    /// きのみ名
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 成長時間
    /// </summary>
    [JsonPropertyName("growth_time")]
    public required int GrowthTime { get; set; }

    /// <summary>
    /// 1回の収穫で取得できる最大数（第４世代以降）
    /// </summary>
    [JsonPropertyName("max_harvest")]
    public required int MaxHarvest { get; set; }

    /// <summary>
    /// 「しぜんのめぐみ」の威力
    /// </summary>
    [JsonPropertyName("natural_gift_power")]
    public required int NaturalGiftPower { get; set; }

    /// <summary>
    /// きのみのサイズ
    /// </summary>
    [JsonPropertyName("size")]
    public required int Size { get; set; }

    /// <summary>
    /// 滑らかさ
    /// </summary>
    [JsonPropertyName("smoothness")]
    public required int Smoothness { get; set; }

    /// <summary>
    /// 土壌を乾燥させる速度
    /// </summary>
    [JsonPropertyName("soil_dryness")]
    public required int SoilDryness { get; set; }

    /// <summary>
    /// 固さ
    /// </summary>
    [JsonPropertyName("firmness")]
    public required KNamedAPIResource Firmness { get; set; }

    /// <summary>
    /// 味リスト
    /// </summary>
    [JsonPropertyName("flavors")]
    public required List<KFlavorBerryMap> Flavors { get; set; }

    /// <summary>
    /// アイテム
    /// </summary>
    [JsonPropertyName("item")]
    public required KNamedAPIResource Item { get; set; }

    /// <summary>
    /// 「しぜんのめぐみ」の技タイプ
    /// </summary>
    [JsonPropertyName("natural_gift_type")]
    public required KNamedAPIResource NaturalGiftType { get; set; }


    /// <summary>
    /// きのみリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>きのみリソース</returns>
    /// <exception cref="Exception"></exception>
    public static KBerry GetBerry(string url)
    {
        string json = KPokeAPIClient.GetJson(url);

        return JsonSerializer.Deserialize<KBerry>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
