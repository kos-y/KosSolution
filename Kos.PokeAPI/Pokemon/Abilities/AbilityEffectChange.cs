using System.ComponentModel;
using System.Text.Json.Serialization;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.Abilities;

/// <summary>
/// バージョンごとの効果
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class AbilityEffectChange
{
    #region 効果リスト
    /// <summary>
    /// 効果リスト
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [DisplayName("effect_entries")]
    [Category("(基本)")]
    [Description("効果リスト")]
    [TypeConverter(typeof(ListConverter<Effect>))]
    public IReadOnlyList<Effect>? EffectEntries { get; set; }
    #endregion

    #region バージョングループ
    /// <summary>
    /// バージョングループ
    /// </summary>
    [JsonPropertyName("version_group")]
    [DisplayName("version_group")]
    [Category("(基本)")]
    [Description("バージョングループ")]
    public NamedAPIResource? VersionGroup { get; set; }
    #endregion
}
