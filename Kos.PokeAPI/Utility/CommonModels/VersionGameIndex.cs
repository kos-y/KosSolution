using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Utility.CommonModels;

/// <summary>
/// バージョン ゲームIndex
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class VersionGameIndex
{
    // フィールド

    #region ゲームIndex
    /// <summary>
    /// ゲームインデックス
    /// </summary>
    [JsonPropertyName("game_index")]
    [DisplayName("game_index")]
    [Category("(基本)")]
    [Description("ゲームIndex")]
    public int? GameIndex { get; set; }
    #endregion

    #region バージョン
    /// <summary>
    /// バージョン
    /// </summary>
    [JsonPropertyName("version")]
    [DisplayName("version")]
    [Category("(基本)")]
    [Description("バージョン")]
    public NamedAPIResource? Version { get; set; }
    #endregion
}
