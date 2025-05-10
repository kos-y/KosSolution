using System.ComponentModel;
using System.Text.Json.Serialization;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.Berries;

/// <summary>
/// きのみの味と強さ
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BerryFlavorMap
{
    #region 味
    /// <summary>
    /// 味
    /// </summary>
    [JsonPropertyName("flavor")]
    [DisplayName("flavor")]
    [Category("(基本)")]
    [Description("味")]
    public NamedAPIResource? Flavor { get; set; }
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

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        return $"{Flavor} {Potency}";
    }
    #endregion
}
