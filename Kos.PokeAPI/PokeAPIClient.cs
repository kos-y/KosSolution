using System;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Kos.Core;

namespace Kos.PokeAPI;

/// <summary>
/// PokeAPI クライアント
/// </summary>
public class PokeAPIClient
{
    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    static PokeAPIClient()
    {
        Singleton<HttpClient>.Instance
                             .DefaultRequestHeaders
                             .Accept
                             .Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    #endregion

    #region APIリソースリストのJSON文字列を取得
    /// <summary>
    /// APIリソースリストのJSON文字列を取得
    /// </summary>
    /// <param name="endPoint">エンドポイント</param>
    /// <returns>JSON文字列</returns>
    public static string GetAPIResourceListEndPoint(string endPoint)
    {
        HttpClient client = Singleton<HttpClient>.Instance;

        for (int i = 0; i < 5; i++) {
            Task<HttpResponseMessage> t = client.GetAsync($"https://pokeapi.co/api/v2/{endPoint}/");
            t.Wait();

            // 成功でコンテンツが空ならリトライ
            if (t.Result.StatusCode == HttpStatusCode.OK) {
                if (t.Result.Content.Headers.ContentLength <= 0) {
                    continue;
                }

                return t.Result.Content.ReadAsStringAsync().Result;
            }

            // 一応リトライ
            continue;
        }

        throw new Exception("5回連続失敗");
    }
    #endregion

    #region URLからJSON文字列の取得
    /// <summary>
    /// URLからJSON文字列の取得
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns>JSON文字列</returns>
    /// <exception cref="ArgumentException">PokeAPIのURLではない</exception>
    public static string GetAPIResourceUrl(string url)
    {
        if (!url.Contains("pokeapi")) {
            throw new ArgumentException("PokeAPIのURLではありません。", url);
        }

        HttpClient client = Singleton<HttpClient>.Instance;

        for (int i = 0; i < 5; i++) {
            Task<HttpResponseMessage> t = client.GetAsync(url);
            t.Wait();

            // 成功でコンテンツが空ならリトライ
            if (t.Result.StatusCode == HttpStatusCode.OK) {
                if (t.Result.Content.Headers.ContentLength <= 0) {
                    continue;
                }

                return t.Result.Content.ReadAsStringAsync().Result;
            }

            // 一応リトライ
            continue;
        }

        throw new Exception("5回連続失敗");
    }
    #endregion
}
