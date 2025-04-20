using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kos.PokeAPI.Attribute;

/// <summary>
/// リソースカテゴリ Attribute
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class ResourceCategoryAttribute : System.Attribute
{
    // フィールド

    #region リソースカテゴリ名
    /// <summary>
    /// リソースカテゴリ名
    /// </summary>
    public string Name { get; }
    #endregion

    #region エンド・ポイント配列
    /// <summary>
    /// エンドポイント配列
    /// </summary>
    public EndPoint[] EndPoints { get; }
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="name">リソースカテゴリ名</param>
    /// <param name="endPoints">エンドポイント配列</param>
    public ResourceCategoryAttribute(string name, params EndPoint[] endPoints)
    {
        Name = name;
        EndPoints = endPoints;
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
