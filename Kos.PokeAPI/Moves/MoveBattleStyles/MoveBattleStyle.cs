using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.PokeAPI.Moves.MoveAilments;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.MoveBattleStyles;

/// <summary>
/// 技の戦闘スタイル
/// </summary>
public class MoveBattleStyle
{
    #region 技の戦闘スタイルID
    /// <summary>
    /// 技の戦闘スタイルID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    #endregion

    #region 技の戦闘スタイル名
    /// <summary>
    /// 技の戦闘スタイル名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    public List<Name>? Names { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static MoveBattleStyle? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<MoveBattleStyle>(json);
    }
    #endregion
}
