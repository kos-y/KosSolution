using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kos.PokeAPI;

public class PokeAPI
{
    // 静的 メソッド

    #region リソースカテゴリの取得
    /// <summary>
    /// リソースカテゴリの取得
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<string> GetCategories()
    {
        yield return nameof(ResourceCategory.Berries);
        yield return nameof(ResourceCategory.Contests);
        yield return nameof(ResourceCategory.Encounters);
        yield return nameof(ResourceCategory.Evolution);
        yield return nameof(ResourceCategory.Games);
        yield return nameof(ResourceCategory.Items);
        yield return nameof(ResourceCategory.Locations);
        yield return nameof(ResourceCategory.Machines);
        yield return nameof(ResourceCategory.Moves);
        yield return nameof(ResourceCategory.Pokemon);
        yield return nameof(ResourceCategory.Utility);
    }
    #endregion


}
