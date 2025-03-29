﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KCSPokeAPI;

/// <summary>
/// PokeAPI
/// </summary>
public class KPokeAPI
{
    /// <summary>
    /// 言語リソースリストの取得
    /// </summary>
    /// <returns>言語リソースリスト</returns>
    public static KNamedAPIResourceList GetLanguages()
    {
        return GetNamedAPIResourceList("language");
    }

    /// <summary>
    /// きのみリソースリストの取得
    /// </summary>
    /// <returns>きのみリソースリスト</returns>
    public static KNamedAPIResourceList GetBerries()
    {
        return GetNamedAPIResourceList("berry");
    }

    /// <summary>
    /// APIリソースリストの解析
    /// </summary>
    /// <param name="endPoint">エンド・ポイント</param>
    /// <returns></returns>
    /// <exception cref="Exception">JSON文字列の解析に失敗</exception>
    public static KAPIResourceList GetAPIResourceList(string endPoint)
    {
        string json = KPokeAPIClient.GetAPIResourceListEndPoint(endPoint);

        return JsonSerializer.Deserialize<KAPIResourceList>(json) ?? throw new Exception("Failed to parse JSON string.");
    }

    /// <summary>
    /// 名前付きAPIリソースリストの解析
    /// </summary>
    /// <param name="endPoint"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static KNamedAPIResourceList GetNamedAPIResourceList(string endPoint)
    {
        string json = KPokeAPIClient.GetAPIResourceListEndPoint(endPoint);

        return JsonSerializer.Deserialize<KNamedAPIResourceList>(json) ?? throw new Exception("Failed to parse JSON string.");
    }
}
