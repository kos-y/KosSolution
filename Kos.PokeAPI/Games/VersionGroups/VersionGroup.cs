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
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("バージョングループID")]
    public int? Id { get; set; }
    #endregion

    #region バージョングループの名前
    /// <summary>
    /// バージョングループの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("バージョングループの名前")]
    public string? Name { get; set; }
    #endregion

    #region 順番
    /// <summary>
    /// 順番
    /// </summary>
    [JsonPropertyName("order")]
    [DisplayName("order")]
    [Category("(基本)")]
    [Description("順番")]
    public int? Order { get; set; }
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

    #region 技の習得方法リスト
    /// <summary>
    /// 技の習得方法リスト
    /// </summary>
    [JsonPropertyName("move_learn_methods")]
    [DisplayName("move_learn_methods")]
    [Category("(基本)")]
    [Description("技の習得方法リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? MoveLearnMethods { get; set; }
    #endregion

    #region ポケモン図鑑リスト
    /// <summary>
    /// ポケモン図鑑リスト
    /// </summary>
    [JsonPropertyName("pokedexes")]
    [DisplayName("pokedexes")]
    [Category("(基本)")]
    [Description("ポケモン図鑑リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Pokedexes { get; set; }
    #endregion

    #region 地域リスト
    /// <summary>
    /// 地域リスト
    /// </summary>
    [JsonPropertyName("regions")]
    [DisplayName("regions")]
    [Category("(基本)")]
    [Description("地域リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Regions { get; set; }
    #endregion

    #region バージョンリスト
    /// <summary>
    /// バージョンリスト
    /// </summary>
    [JsonPropertyName("versions")]
    [DisplayName("versions")]
    [Category("(基本)")]
    [Description("バージョンリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Versions { get; set; }
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
