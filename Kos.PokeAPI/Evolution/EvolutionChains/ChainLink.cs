using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Evolution.EvolutionChains;

/// <summary>
/// チェーンリンク
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ChainLink
{
    // フィールド

    #region ベビーポケモンか
    /// <summary>
    /// ベビーポケモンか
    /// </summary>
    [JsonPropertyName("is_baby")]
    [DisplayName("is_baby")]
    [Category("(基本)")]
    [Description("ベビーポケモンかどうか")]
    public bool? IsBaby { get; set; }
    #endregion

    #region ポケモン種族
    /// <summary>
    /// ポケモン種族
    /// </summary>
    [JsonPropertyName("species")]
    [DisplayName("species")]
    [Category("(基本)")]
    [Description("ポケモン種族")]
    public NamedAPIResource? Species { get; set; }
    #endregion

    #region 進化条件詳細リスト
    /// <summary>
    /// 進化条件詳細リスト
    /// </summary>
    [JsonPropertyName("evolution_details")]
    [DisplayName("evolution_details")]
    [Category("(基本)")]
    [Description("遭遇条件値リスト")]
    [TypeConverter(typeof(ListConverter<EvolutionDetail>))]
    public IReadOnlyList<EvolutionDetail>? EvolutionDetails { get; set; }
    #endregion

    #region 進化先リスト
    /// <summary>
    /// 進化先リスト
    /// </summary>
    [JsonPropertyName("evolves_to")]
    [DisplayName("evolution_details")]
    [Category("(基本)")]
    [Description("遭遇条件値リスト")]
    [TypeConverter(typeof(ListConverter<ChainLink>))]
    public IReadOnlyList<ChainLink>? EvolvesTo { get; set; }
    #endregion

    #region 文字列
    /// <summary>
    /// 文字列
    /// </summary>
    [Category("(基本)")]
    [Description("概略テキスト")]
    public string Text => ToString();
    #endregion


    // メソッド

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        List<string> texts = [];

        if (IsBaby ?? false) {
            texts.Add("Baby");
        }

        if (Species is not null) {
            texts.Add($"{Species.Name}");
        }

        return string.Join(" / ", texts);
    }
    #endregion
}
