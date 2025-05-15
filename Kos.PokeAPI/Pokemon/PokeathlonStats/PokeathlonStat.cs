using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Pokemon.PokeathlonStats;

/// <summary>
/// ポケスロンのステータス
/// </summary>
public class PokeathlonStat
{
    #region ポケスロンのステータスID
    /// <summary>
    /// ポケスロンのステータスID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("id")]
    [Category("(基本)")]
    [Description("ポケスロンのステータスID")]
    public int Id { get; set; }
    #endregion

    #region ポケスロンのステータスの名前
    /// <summary>
    /// ポケスロンのステータスの名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("name")]
    [Category("(基本)")]
    [Description("ポケスロンのステータスの名前")]
    public string? Name { get; set; }
    #endregion

    #region 言語ごとの名前
    /// <summary>
    /// 言語ごとの名前
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("言語ごとの名前")]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion

    #region 性格が影響を受けるステータス
    /// <summary>
    /// 性格が影響を受けるステータス
    /// </summary>
    [JsonPropertyName("affecting_natures")]
    [DisplayName("affecting_natures")]
    [Category("(基本)")]
    [Description("性格が影響を受けるステータス")]
    public NaturePokeathlonStatAffectSets? AffectingNatures { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static PokeathlonStat? GetResource(string url)
    {
        for (int i = 0; i < 5; i++) {
            try {
                string json = PokeAPIClient.GetAPIResourceUrl(url);

                return JsonSerializer.Deserialize<PokeathlonStat>(json);
            } catch (JsonException) {
            }
        }

        return null;
    }
    #endregion
}
