using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// エンカウント バージョンごとの詳細
/// </summary>
public class VersionEncounterDetail
{
    // フィールド

    #region バージョン
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    public NamedAPIResource? Version { get; set; }
    #endregion

    #region エンカウント 最大確立
    /// <summary>
    /// エンカウントの最大確率
    /// </summary>
    [JsonPropertyName("max_chance")]
    public int? MaxChance { get; set; }
    #endregion

    #region エンカウント 詳細
    /// <summary>
    /// エンカウントの詳細
    /// </summary>
    [JsonPropertyName("encounter_details")]
    public List<Encounter>? EncounterDetails { get; set; }
    #endregion
}
