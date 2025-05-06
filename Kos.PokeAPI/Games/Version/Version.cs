using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Games.Version;

/// <summary>
/// バージョン
/// </summary>
public class Version
{
    // フィールド

    #region バージョンID
    /// <summary>
    /// バージョンID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region バージョン名
    /// <summary>
    /// バージョン名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region バージョン名リスト
    /// <summary>
    /// バージョン名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion


    // メソッド

    #region バージョンリソースの取得
    /// <summary>
    /// バージョンリソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>バージョンリソース</returns>
    public static Version? GetVersion(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Version>(json);
    }
    #endregion
}
