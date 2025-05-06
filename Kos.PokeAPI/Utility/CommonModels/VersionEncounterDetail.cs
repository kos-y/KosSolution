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

    #region 遭遇最大確立
    /// <summary>
    /// 遭遇最大確率
    /// </summary>
    [JsonPropertyName("max_chance")]
    public int? MaxChance { get; set; }
    #endregion

    #region 遭遇情報詳細リスト
    /// <summary>
    /// 遭遇情報詳細リスト
    /// </summary>
    [JsonPropertyName("encounter_details")]
    public List<Encounter>? EncounterDetails { get; set; }
    #endregion
}
