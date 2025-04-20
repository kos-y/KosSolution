using Kos.Core;

namespace Kos.PokeAPI;

/// <summary>
/// PokeAPI クライアント
/// </summary>
public class PokeAPIClient
{
    // メソッド

    #region APIリソースリストのJSON文字列を取得
    /// <summary>
    /// APIリソースリストのJSON文字列を取得
    /// </summary>
    /// <param name="endPoint">エンドポイント</param>
    /// <returns>JSON文字列</returns>
    public static string GetAPIResourceListEndPoint(string endPoint)
    {
        HttpClient client = Singleton<HttpClient>.Instance;

        return client.GetStringAsync($"https://pokeapi.co/api/v2/{endPoint}/").Result;
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

        return client.GetStringAsync(url).Result;
    }
    #endregion
}
