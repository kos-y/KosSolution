using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;
using Kos.Core;
using System.ComponentModel;

namespace Kos.PokeAPI.Encounters.EncounterConditionValues;

/// <summary>
/// 遭遇条件値
/// </summary>
public class EncounterConditionValue
{
    #region 遭遇条件値ID
    /// <summary>
    /// 遭遇条件値ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("遭遇条件値ID")]
    public int? Id { get; set; }
    #endregion

    #region 遭遇条件値の名前
    /// <summary>
    /// 遭遇条件値の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("遭遇条件値の名前")]
    public string? Name { get; set; }
    #endregion

    #region 遭遇条件
    /// <summary>
    /// 遭遇条件
    /// </summary>
    [JsonPropertyName("condition")]
    [DisplayName("condition")]
    [Category("(基本)")]
    [Description("遭遇条件")]
    public NamedAPIResource? Condition { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("遭遇条件値リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion


    // メソッド

    #region エンカウント条件値リソースの取得
    /// <summary>
    /// エンカウント条件値リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>エンカウント条件値リソース</returns>
    public static EncounterConditionValue? GetEncountConditionValue(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<EncounterConditionValue>(json);
    }
    #endregion
}
