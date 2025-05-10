using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Items.Item;

/// <summary>
/// アイテム スプライト
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ItemSprites
{
    #region デフォルト
    /// <summary>
    /// デフォルト
    /// </summary>
    [JsonPropertyName("default")]
    [DisplayName("default")]
    [Category("(基本)")]
    [Description("デフォルト")]
    public string? Default { get; set; }
    #endregion
}
