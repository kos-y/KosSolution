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
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("バージョンID")]
    public int? Id { get; set; }
    #endregion

    #region バージョンの名前
    /// <summary>
    /// バージョンの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("バージョンの名前")]
    public string? Name { get; set; }
    #endregion

    #region バージョン名リスト
    /// <summary>
    /// バージョン名リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    [DisplayName("version_group")]
    [Category("(基本)")]
    [Description("バージョングループ")]
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
