using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.MoveCategories;

/// <summary>
/// 技のカテゴリ
/// </summary>
public class MoveCategory
{
    #region 技のカテゴリID
    /// <summary>
    /// 技のカテゴリID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("技のカテゴリID")]
    public int? Id { get; set; }
    #endregion

    #region 技のカテゴリの名前
    /// <summary>
    /// 技のカテゴリの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("技のカテゴリの名前")]
    public string? Name { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    [DisplayName("moves")]
    [Category("(基本)")]
    [Description("技リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Moves { get; set; }
    #endregion

    #region 説明リスト
    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    [DisplayName("descriptions")]
    [Category("(基本)")]
    [Description("説明リスト")]
    [TypeConverter(typeof(ListConverter<Description>))]
    public IReadOnlyList<Description>? Descriptions { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static MoveCategory? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<MoveCategory>(json);
    }
    #endregion
}
