using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Pokemon.GrowthRates;

/// <summary>
/// レベルごとに必要な経験値
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class GrowthRateExperienceLevel
{
    #region レベル
    /// <summary>
    /// レベル
    /// </summary>
    [JsonPropertyName("level")]
    [DisplayName("level")]
    [Category("(基本)")]
    [Description("レベル")]
    public int? Level { get; set; }
    #endregion

    #region 経験値
    /// <summary>
    /// 経験値
    /// </summary>
    [JsonPropertyName("experience")]
    [DisplayName("exprerience")]
    [Category("(基本)")]
    [Description("経験値")]
    public int? Experience { get; set; }
    #endregion
}
