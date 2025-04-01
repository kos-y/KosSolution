using System;
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
    /// きのみの固さリソースリストの取得
    /// </summary>
    /// <returns>きのみの固さリソースリスト</returns>
    public static KNamedAPIResourceList GetBerryFirmnesses()
    {
        return GetNamedAPIResourceList("berry-firmness");
    }

    /// <summary>
    /// きのみの味リソースリストの取得
    /// </summary>
    /// <returns>きのみの味リソースリスト</returns>
    public static KNamedAPIResourceList GetBerryFlavors()
    {
        return GetNamedAPIResourceList("berry-flavor");
    }

    /// <summary>
    /// コンテストタイプリソースリストの取得
    /// </summary>
    /// <returns></returns>
    public static KNamedAPIResourceList GetContestTypes()
    {
        return GetNamedAPIResourceList("contest-type");
    }

    /// <summary>
    /// コンテスト効果リソースリストの取得
    /// </summary>
    /// <returns></returns>
    public static KAPIResourceList GetContestEffects()
    {
        return GetAPIResourceList("contest-effect");
    }

    /// <summary>
    /// スーパーコンテストの効果リソースリストの取得
    /// </summary>
    /// <returns></returns>
    public static KAPIResourceList GetSuperContestEffects()
    {
        return GetAPIResourceList("super-contest-effect");
    }

    /// <summary>
    /// エンカウントの方法リソースリストの取得
    /// </summary>
    /// <returns></returns>
    public static KNamedAPIResourceList GetEncounterMethods()
    {
        return GetNamedAPIResourceList("encounter-method");
    }

    /// <summary>
    /// エンカウント条件リソースリストの取得
    /// </summary>
    /// <returns></returns>
    public static KNamedAPIResourceList GetEncounterConditions()
    {
        return GetNamedAPIResourceList("encounter-condition");
    }

    /// <summary>
    /// エンカウント条件値リソースリストの取得
    /// </summary>
    /// <returns></returns>
    public static KNamedAPIResourceList GetEncounterConditionValues()
    {
        return GetNamedAPIResourceList("encounter-condition-value");
    }

    /// <summary>
    /// 進化チェーンリソースリストの取得
    /// </summary>
    /// <returns></returns>
    public static KAPIResourceList GetEvolutionChains()
    {
        return GetAPIResourceList("evolution-chain");
    }

    /// <summary>
    /// 進化トリガーリソースリストの取得
    /// </summary>
    /// <returns></returns>
    public static KNamedAPIResourceList GetEvolutionTriggers()
    {
        return GetNamedAPIResourceList("evolution-trigger");
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
