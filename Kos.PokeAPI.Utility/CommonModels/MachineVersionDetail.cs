using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 技マシン バージョンごとの詳細
/// </summary>
public class MachineVersionDetail
{
    // フィールド

    #region 技マシン
    /// <summary>
    /// 技マシン
    /// </summary>
    [JsonPropertyName("machine")]
    public APIResource? Machine { get; set; }
    #endregion

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion
}
