using System.Text.Json.Serialization;
using System.Text.Json;
using Kos.PokeAPI.Utility.CommonModels;
using System.ComponentModel;
using Kos.Core;
using Kos.PokeAPI.Locations.LocationAreas;

namespace Kos.PokeAPI.Locations.Locations;

/// <summary>
/// 場所
/// </summary>
public class Location
{
    #region 場所ID
    /// <summary>
    /// 場所ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("場所ID")]
    public int? Id { get; set; }
    #endregion

    #region 場所の名前
    /// 場所名
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("場所の名前")]
    public string? Name { get; set; }
    #endregion

    #region 地域
    /// <summary>
    /// 地域
    /// </summary>
    [JsonPropertyName("region")]
    [DisplayName("region")]
    [Category("(基本)")]
    [Description("地域")]
    public NamedAPIResource? Region { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 場所名リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public List<Name>? Names { get; set; }
    #endregion

    #region 世代ごとのゲームIndexリスト
    /// <summary>
    /// 世代ごとのゲームIndexリスト
    /// </summary>
    [JsonPropertyName("game_indices")]
    [DisplayName("game_indices")]
    [Category("(基本)")]
    [Description("世代ごとのゲームIndexリスト")]
    [TypeConverter(typeof(ListConverter<GenerationGameIndex>))]
    public List<GenerationGameIndex>? GameIndices { get; set; }
    #endregion

    #region エリアリスト
    /// <summary>
    /// エリアリスト
    /// </summary>
    [JsonPropertyName("areas")]
    [DisplayName("areas")]
    [Category("(基本)")]
    [Description("エリアリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public List<NamedAPIResource>? Areas { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static Location? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<Location>(json);
    }
    #endregion
}
