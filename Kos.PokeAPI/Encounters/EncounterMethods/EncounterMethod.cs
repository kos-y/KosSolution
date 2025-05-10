using System.Text.Json.Serialization;
using System.Text.Json;
using Kos.PokeAPI.Utility.CommonModels;
using System.ComponentModel;
using Kos.Core;

namespace Kos.PokeAPI.Encounters.EncounterMethods;

/// <summary>
/// 遭遇方法
/// </summary>
public class EncounterMethod
{
    // フィールド

    #region 遭遇方法ID
    /// <summary>
    /// 遭遇方法ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("遭遇方法ID")]
    public int? Id { get; set; }
    #endregion

    #region 遭遇方法の名前
    /// <summary>
    /// 遭遇方法の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("遭遇方法の名前")]
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

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion


    // 静的メソッド

    #region エンカウントの方法リソースの取得
    /// <summary>
    /// エンカウントの方法リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>エンカウントの方法リソース</returns>
    public static EncounterMethod? GetEncountMethod(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<EncounterMethod>(json);
    }
    #endregion
}
