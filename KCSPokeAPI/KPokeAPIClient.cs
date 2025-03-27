using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using KCSCore;

namespace KCSPokeAPI;

/// <summary>
/// PokeAPI通信クライアント
/// </summary>
internal class KPokeAPIClient
{
    /// <summary>
    /// APIリソースリストのJSON文字列を取得
    /// </summary>
    /// <param name="endPoint">エンドポイント</param>
    /// <returns>JSON文字列</returns>
    internal static string GetAPIResourceListEndPoint(string endPoint)
    {
        HttpClient client = KSingleton<HttpClient>.Instance;

        return client.GetStringAsync($"https://pokeapi.co/api/v2/{endPoint}/").Result;
    }

    /// <summary>
    /// URLからJSON文字列の取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>JSON文字列</returns>
    /// <exception cref="ArgumentException"></exception>
    internal static string GetJson(string url)
    {
        if (!url.Contains("pokeapi")) {
            throw new ArgumentException("PokeAPIのURLではありません。", url);
        }

        HttpClient client = KSingleton<HttpClient>.Instance;

        return client.GetStringAsync(url).Result;
    }
}
