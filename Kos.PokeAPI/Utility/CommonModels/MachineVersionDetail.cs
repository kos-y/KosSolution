using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// 技マシン バージョンごとの詳細
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class MachineVersionDetail
{
    // フィールド

    #region 技マシン
    /// <summary>
    /// 技マシン
    /// </summary>
    [JsonPropertyName("machine")]
    [DisplayName("machine")]
    [Category("(基本)")]
    [Description("技マシン")]
    public APIResource? Machine { get; set; }
    #endregion

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    [DisplayName("version_group")]
    [Category("(基本)")]
    [Description("バージョングループ")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion
}
