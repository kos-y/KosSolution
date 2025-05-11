using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// コンテストのコンボ詳細
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ContestComboDetail
{
    #region この技の前に使用する技リスト
    /// <summary>
    /// この技の前に使用する技リスト
    /// </summary>
    [JsonPropertyName("use_before")]
    [DisplayName("use_before")]
    [Category("(基本)")]
    [Description("この技の前に使用する技リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? UseBefore { get; set; }
    #endregion

    #region この技の後に使用する技リスト
    /// <summary>
    /// この技の後に使用する技リスト
    /// </summary>
    [JsonPropertyName("use_after")]
    [DisplayName("use_after")]
    [Category("(基本)")]
    [Description("この技の後に使用する技リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? UseAfter { get; set; }
    #endregion
}
