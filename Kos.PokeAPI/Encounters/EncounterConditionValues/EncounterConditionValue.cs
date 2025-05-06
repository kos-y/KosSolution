using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Encounters.EncounterConditionValues;

/// <summary>
/// 遭遇条件値
/// </summary>
public class EncounterConditionValue
{
    #region エンカウント条件値ID
    /// <summary>
    /// エンカウント条件値ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region エンカウント条件値名
    /// <summary>
    /// エンカウント条件値名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region エンカウント条件
    /// <summary>
    /// エンカウント条件
    /// </summary>
    [JsonPropertyName("condition")]
    public NamedAPIResource? Condition { get; set; }
    #endregion

    #region エンカウント条件値名リスト
    /// <summary>
    /// エンカウント条件値名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
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
