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

namespace Kos.PokeAPI.Moves.MoveAilments;

/// <summary>
/// 状態異常技
/// </summary>
public class MoveAilment
{
    #region 状態異常ID
    /// <summary>
    /// 状態異常ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("状態異常ID")]
    public int? Id { get; set; }
    #endregion

    #region 状態異常の名前
    /// <summary>
    /// 状態異常名
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("状態異常の名前")]
    public string? Name { get; set; }
    #endregion

    #region 状態異常が発動する技リスト
    /// <summary>
    /// 状態異常が発動する技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    [DisplayName("moves")]
    [Category("(基本)")]
    [Description("状態異常が発動する技リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Moves { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 状態異常名リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static MoveAilment? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<MoveAilment>(json);
    }
    #endregion
}
