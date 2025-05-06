using System.Text.Json;
using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Machines.Machines;

/// <summary>
/// 技マシン
/// </summary>
public class Machine
{
    #region 技マシンID
    /// <summary>
    /// 技マシンID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region アイテム
    /// <summary>
    /// アイテム
    /// </summary>
    [JsonPropertyName("item")]
    public NamedAPIResource? Item { get; set; }
    #endregion

    #region 技
    /// <summary>
    /// 技
    /// </summary>
    [JsonPropertyName("move")]
    public NamedAPIResource? Move { get; set; }
    #endregion

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Machine? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Machine>(json);
    }
    #endregion

}
