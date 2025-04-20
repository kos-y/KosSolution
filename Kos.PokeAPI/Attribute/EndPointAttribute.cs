using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Attribute;

/// <summary>
/// エンド・ポイント Attribute
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class EndPointAttribute : System.Attribute
{
    // フィールド

    #region エンドポイント名
    /// <summary>
    /// エンドポイント名
    /// </summary>
    public string Name { get; set; }
    #endregion

    #region エンドポイント
    /// <summary>
    /// エンドポイント
    /// </summary>
    public string EndPoint { get; }
    #endregion

    #region エンドポイント（サブ）
    /// <summary>
    /// エンドポイント（サブ）
    /// </summary>
    public string? EndPointSub { get; }
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="name">エンドポイント名</param>
    /// <param name="endPoint">エンドポイント</param>
    /// <param name="endPointSub">エンドポイント（サブ）</param>
    public EndPointAttribute(string name, string endPoint, string? endPointSub = null)
    {
        Name = name;
        EndPoint = endPoint;
        EndPointSub = endPointSub;
    }
    #endregion

    #region 文字列化
    /// <summary>
    /// 文字列化
    /// </summary>
    /// <returns>文字列</returns>
    public override string ToString()
    {
        return Name;
    }
    #endregion
}
