using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// コンテストのコンボ詳細
/// </summary>
public class ContestComboDetail
{
    #region この技の前に使用する技リスト
    /// <summary>
    /// この技の前に使用する技リスト
    /// </summary>
    [JsonPropertyName("use_before")]
    public List<NamedAPIResource>? UseBefore { get; set; }
    #endregion

    #region この技の後に使用する技リスト
    /// <summary>
    /// この技の後に使用する技リスト
    /// </summary>
    [JsonPropertyName("use_after")]
    public List<NamedAPIResource>? UseAfter { get; set; }
    #endregion
}
