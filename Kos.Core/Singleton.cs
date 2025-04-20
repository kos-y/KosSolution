namespace Kos.Core;

/// <summary>
/// Singletonパターン
/// </summary>
/// <typeparam name="T">Singletonにする型</typeparam>
public class Singleton<T> where T : new()
{
    // public 静的フィールド

    #region インスタンスのgetter
    /// <summary>
    /// インスタンスのgetter
    /// </summary>
    public static T Instance => s_instance;
    #endregion


    // private 静的フィールド

    #region 内部で保持するインスタンス
    /// <summary>
    /// 内部で保持するインスタンス
    /// </summary>
    private static readonly T s_instance = new();
    #endregion
}
