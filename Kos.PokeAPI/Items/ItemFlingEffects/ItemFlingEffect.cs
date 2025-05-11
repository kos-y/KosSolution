using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;
using System.ComponentModel;
using Kos.Core;

namespace Kos.PokeAPI.Items.ItemFlingEffects;

/// <summary>
/// 「なげつける」の効果
/// </summary>
public class ItemFlingEffect
{
    #region 効果ID
    /// <summary>
    /// 効果ID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("効果ID")]
    public int? Id { get; set; }
    #endregion

    #region 効果の名前
    /// <summary>
    /// 効果の名前
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("効果の名前")]
    public string? Name { get; set; }
    #endregion

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

    #region アイテムリスト
    /// <summary>
    /// アイテムリスト
    /// </summary>
    [JsonPropertyName("items")]
    [DisplayName("items")]
    [Category("(基本)")]
    [Description("アイテムリスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Items { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static ItemFlingEffect? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<ItemFlingEffect>(json);
    }
    #endregion
}
