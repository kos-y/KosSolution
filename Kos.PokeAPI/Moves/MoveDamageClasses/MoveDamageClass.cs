﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Moves.MoveDamageClasses;

/// <summary>
/// 技のダメージクラス
/// </summary>
public class MoveDamageClass
{
    #region 技のダメージクラスID
    /// <summary>
    /// 技のダメージクラスID
    /// </summary>
    [JsonPropertyName("id")]
    [DisplayName("(id)")]
    [Category("(基本)")]
    [Description("技のダメージクラスID")]
    public int? Id { get; set; }
    #endregion

    #region 技のダメージクラス名
    /// <summary>
    /// 技のダメージクラス名
    /// </summary>
    [JsonPropertyName("name")]
    [DisplayName("(name)")]
    [Category("(基本)")]
    [Description("技のダメージクラス名")]
    public string? Name { get; set; }
    #endregion

    #region 説明リスト
    /// <summary>
    /// 説明リスト
    /// </summary>
    [JsonPropertyName("descriptions")]
    [DisplayName("descriptions")]
    [Category("(基本)")]
    [Description("説明リスト")]
    [TypeConverter(typeof(ListConverter<Description>))]
    public IReadOnlyList<Description>? Descriptions { get; set; }
    #endregion

    #region 技リスト
    /// <summary>
    /// 技リスト
    /// </summary>
    [JsonPropertyName("moves")]
    [DisplayName("moves")]
    [Category("(基本)")]
    [Description("技リスト")]
    [TypeConverter(typeof(ListConverter<NamedAPIResource>))]
    public IReadOnlyList<NamedAPIResource>? Moves { get; set; }
    #endregion

    #region 言語ごとの名前リスト
    /// <summary>
    /// 言語ごとの名前リスト
    /// </summary>
    [JsonPropertyName("names")]
    [DisplayName("names")]
    [Category("(基本)")]
    [Description("説明リスト")]
    [TypeConverter(typeof(ListConverter<Name>))]
    public IReadOnlyList<Name>? Names { get; set; }
    #endregion


    // メソッド

    #region リソースの取得
    /// <summary>
    /// リソースの取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>リソース</returns>
    public static MoveDamageClass? GetResource(string url)
    {
        string json = PokeAPIClient.GetAPIResourceUrl(url);

        return JsonSerializer.Deserialize<MoveDamageClass>(json);
    }
    #endregion
}
