using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Evolution.EvolutionChains;

/// <summary>
/// チェーンリンク
/// </summary>
public class ChainLink
{
    // フィールド

    #region ベビーポケモンか
    /// <summary>
    /// ベビーポケモンか
    /// </summary>
    [JsonPropertyName("is_baby")]
    public bool? IsBaby { get; set; }
    #endregion

    #region 種族
    /// <summary>
    /// 種族
    /// </summary>
    [JsonPropertyName("species")]
    public NamedAPIResource? Species { get; set; }
    #endregion

    #region 進化条件詳細リスト
    /// <summary>
    /// 進化条件詳細リスト
    /// </summary>
    [JsonPropertyName("evolution_details")]
    public List<EvolutionDetail>? EvolutionDetails { get; set; }
    #endregion

    #region 進化先リスト
    /// <summary>
    /// 進化先リスト
    /// </summary>
    [JsonPropertyName("evolves_to")]
    public List<ChainLink>? EvolvesTo { get; set; }
    #endregion

    #region 文字列
    /// <summary>
    /// 文字列
    /// </summary>
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
