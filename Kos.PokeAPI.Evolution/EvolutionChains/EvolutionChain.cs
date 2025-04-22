using System.Text.Json.Serialization;
using System.Text.Json;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Evolution.EvolutionChains;

/// <summary>
/// 進化チェーン
/// </summary>
public class EvolutionChain
{
    #region 進化チェーンID
    /// <summary>
    /// 進化チェーンID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region ベビーポケモンが進化するアイテム
    /// <summary>
    /// ベビーポケモンが進化するアイテム
    /// </summary>
    [JsonPropertyName("baby_trigger_item")]
    public NamedAPIResource? BabyTriggerItem { get; set; }
    #endregion

    #region チェーン
    /// <summary>
    /// チェーン
    /// </summary>
    [JsonPropertyName("chain")]
    public ChainLink? Chain { get; set; }
    #endregion


    // メソッド

    #region 進化チェーンリソースの取得
    /// <summary>
    /// 進化チェーンリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>進化チェーンリソース</returns>
    public static EvolutionChain? GetEvolutionChain(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<EvolutionChain>(json);
    }
    #endregion
}
