using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.Core.WPF;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Utility.WPF.CommonModels;

/// <summary>
/// 名前付きリソース ViewModel
/// </summary>
public class NamedAPIResourceViewModel : NotifyPropertyChanged
{
    // フィールド

    #region 名前付きリソース
    /// <summary>
    /// 名前付きリソース
    /// </summary>
    private readonly NamedAPIResource _namedAPIResource;
    #endregion

    #region 名前
    /// <summary>
    /// 名前
    /// </summary>
    public string Name =>
        !string.IsNullOrWhiteSpace(_namedAPIResource.Name) ?
            _namedAPIResource.Name :
            string.Empty;
    #endregion

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    public string Url =>
        !string.IsNullOrWhiteSpace(_namedAPIResource.Url) ?
            _namedAPIResource.Url :
            string.Empty;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="namedAPIResource">名前付きAPIリソース</param>
    public NamedAPIResourceViewModel(NamedAPIResource namedAPIResource)
    {
        _namedAPIResource = namedAPIResource;
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
