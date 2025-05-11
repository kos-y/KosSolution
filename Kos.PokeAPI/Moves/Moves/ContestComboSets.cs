using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// コンテストのコンボセット
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ContestComboSets
{
    #region ポケモンコンテスト
    /// <summary>
    /// ポケモンコンテスト
    /// </summary>
    [JsonPropertyName("normal")]
    [DisplayName("normal")]
    [Category("(基本)")]
    [Description("ポケモンコンテスト")]
    public ContestComboDetail? Normal { get; set; }
    #endregion

    #region スーパーコンテスト
    /// <summary>
    /// スーパーコンテスト
    /// </summary>
    [JsonPropertyName("super")]
    [DisplayName("super")]
    [Category("(基本)")]
    [Description("スーパーコンテスト")]
    public ContestComboDetail? Super { get; set; }
    #endregion
}
