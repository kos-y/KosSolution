using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Games.VersionGroups;

/// <summary>
/// バージョングループ
/// </summary>
public class VersionGroup
{
    #region バージョングループID
    /// <summary>
    /// バージョングループID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region バージョングループ名
    /// <summary>
    /// バージョングループ名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 順番
    /// <summary>
    /// 順番
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }
    #endregion

    #region 世代
    /// <summary>
    /// 世代
    /// </summary>
    [JsonPropertyName("generation")]
    public NamedAPIResource? Generation { get; set; }
    #endregion

    #region 技の習得方法リスト
    /// <summary>
    /// 技の習得方法リスト
    /// </summary>
    [JsonPropertyName("move_learn_methods")]
    public List<NamedAPIResource>? MoveLearnMethods { get; set; }
    #endregion

    #region ポケモン図鑑リスト
    /// <summary>
    /// ポケモン図鑑リスト
    /// </summary>
    [JsonPropertyName("pokedexes")]
    public List<NamedAPIResource>? Pokedexes { get; set; }
    #endregion

    #region 地域リスト
    /// <summary>
    /// 地域リスト
    /// </summary>
    [JsonPropertyName("regions")]
    public List<NamedAPIResource>? Regions { get; set; }
    #endregion

    #region バージョンリスト
    /// <summary>
    /// バージョンリスト
    /// </summary>
    [JsonPropertyName("versions")]
    public List<NamedAPIResource>? Versions { get; set; }
    #endregion


    // メソッド

    #region バージョングループリソースの取得
    /// <summary>
    /// バージョングループリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>バージョングループリソース</returns>
    public static VersionGroup? GetVersionGroup(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<VersionGroup>(json);
    }
    #endregion
}
