using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// 技のフレーバーテキスト
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class MoveFlavorText
{
    #region フレーバーテキスト
    /// <summary>
    /// フレーバーテキスト
    /// </summary>
    [JsonPropertyName("flavor_text")]
    [DisplayName("flavor_text")]
    [Category("(基本)")]
    [Description("フレーバーテキスト")]
    public string? FlavorText { get; set; }
    #endregion

    #region 言語
    /// <summary>
    /// 言語
    /// </summary>
    [JsonPropertyName("language")]
    [DisplayName("language")]
    [Category("(基本)")]
    [Description("言語")]
    public NamedAPIResource? Language { get; set; }
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
