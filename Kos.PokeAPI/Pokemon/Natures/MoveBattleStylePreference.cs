using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Natures;

/// <summary>
/// 性格と戦闘スタイルの関係性
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class MoveBattleStylePreference
{
    #region HPが低い状態でどのぐらい好まれるか
    /// </summary>
    /// <summary>
    /// HPが低い状態でどのぐらい好まれるか
    /// </summary>
    [JsonPropertyName("low_hp_preference")]
    [DisplayName("low_hp_preference")]
    [Category("(基本)")]
    [Description("HPが低い状態でどのぐらい好まれるか")]
    public int? LowHPPreference { get; set; }
    #endregion

    #region HPが高い状態でどのぐらい好まれるか
    /// <summary>
    /// HPが高い状態でどのぐらい好まれるか}
    /// </summary>
    [JsonPropertyName("hight_hp_preference")]
    [DisplayName("hight_hp_preference")]
    [Category("(基本)")]
    [Description("HPが高い状態でどのぐらい好まれるか")]
    public int? HighHPPreference { get; set; }
    #endregion

    #region 戦闘スタイル
    /// <summary>
    /// 戦闘スタイル
    /// </summary>
    [JsonPropertyName("move_battle_style")]
    [DisplayName("move_battle_style")]
    [Category("(基本)")]
    [Description("技の戦闘スタイル")]
    public NamedAPIResource? MoveBattleStyle { get; set; }
    #endregion
}
