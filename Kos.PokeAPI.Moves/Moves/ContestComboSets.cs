using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Moves.Moves;

/// <summary>
/// コンテストのコンボセット
/// </summary>
public class ContestComboSets
{
    #region ポケモンコンテスト
    /// <summary>
    /// ポケモンコンテスト
    /// </summary>
    [JsonPropertyName("normal")]
    public ContestComboDetail? Normal { get; set; }
    #endregion

    #region スーパーコンテスト
    /// <summary>
    /// スーパーコンテスト
    /// </summary>
    [JsonPropertyName("super")]
    public ContestComboDetail Super { get; set; }
    #endregion
}
