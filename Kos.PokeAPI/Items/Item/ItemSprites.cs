using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Items.Item;

/// <summary>
/// アイテム スプライト
/// </summary>
public class ItemSprites
{
    #region デフォルト
    /// <summary>
    /// デフォルト
    /// </summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }
    #endregion
}
