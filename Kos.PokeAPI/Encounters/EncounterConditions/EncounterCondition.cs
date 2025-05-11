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

namespace Kos.PokeAPI.Encounters.EncounterConditions;

/// <summary>
/// 遭遇条件
/// </summary>
public class EncounterCondition
{
    // フィールド

    #region 遭遇条件ID
    /// <summary>
    /// 遭遇条件ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("遭遇条件ID")]
    public int? Id { get; set; }
    #endregion

    #region 遭遇条件の名前
    /// <summary>
    /// 遭遇条件の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("遭遇条件の名前")]
    public string? Name { get; set; }
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

    #region 遭遇条件値リスト
    /// <summary>
    /// 遭遇条件値リスト
    /// </summary>
    [JsonPropertyName("values")]
    [DisplayName("values")]
    [Category("(基本)")]
    [Description("遭遇条件値リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Values { get; set; }
    #endregion


    // メソッド

    #region エンカウント条件リソースの取得
    /// <summary>
    /// エンカウント条件リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>エンカウント条件リソース</returns>
    public static EncounterCondition? GetEncountCondition(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<EncounterCondition>(json);
    }
    #endregion
}
