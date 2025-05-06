using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Encounters.EncounterConditions;

/// <summary>
/// 遭遇条件
/// </summary>
public class EncounterCondition
{
    // フィールド

    #region エンカウント条件ID
    /// <summary>
    /// エンカウント条件)D
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region エンカウント条件名
    /// <summary>
    /// エンカウント条件名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region エンカウント条件名リスト
    /// <summary>
    /// エンカウント条件名リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion

    #region エンカウント条件値リスト
    /// <summary>
    /// エンカウント条件値リスト
    /// </summary>
    [JsonPropertyName("values")]
    public List<NamedAPIResource>? Values { get; set; }
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
