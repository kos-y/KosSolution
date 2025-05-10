using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.BerryFlavors;

/// <summary>
/// きのみと味の強さ
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class FlavorBerryMap
{
    #region きのみ
    /// <summary>
    /// きのみ
    /// </summary>
    [JsonPropertyName("berry")]
    [DisplayName("berry")]
    [Category("(基本)")]
    [Description("きのみ")]
    public NamedAPIResource? Berry { get; set; }
    #endregion

    #region 味の強さ
    /// <summary>
    /// 味の強さ
    /// </summary>
    [JsonPropertyName("potency")]
    [DisplayName("potency")]
    [Category("(基本)")]
    [Description("味の強さ")]
    public int? Potency { get; set; }
    #endregion


    // メソッド

    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        return $"{Berry} {Potency}";
    }
}
