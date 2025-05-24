using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.Core.WPF;
using Kos.PokeAPI.Attribute;
using Kos.PokeAPI.ResourceLists;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.WPF.ResourceLists;

/// <summary>
/// 名前付きAPIリソースリスト ViewModel
/// </summary>
public class NamedAPIResourceListViewModel : NotifyPropertyChanged
{
    #region 前ページURL
    /// <summary>
    /// 前ページURL
    /// </summary>
    public string? PreviousPageUrl
    {
        get => _previousPageUrl;
        set {
            _previousPageUrl = value;
            RaisePropertyChanged();
        }
    }

    /// <summary>
    /// 前ページURL
    /// </summary>
    private string? _previousPageUrl;
    #endregion

    #region 次ページURL
    /// <summary>
    /// 次ページURL
    /// </summary>
    public string? NextPageUrl
    {
        get => _nextPageUrl;
        set {
            _nextPageUrl = value;
            RaisePropertyChanged();
        }
    }

    /// <summary>
    /// 次ページURL
    /// </summary>
    private string? _nextPageUrl;
    #endregion

    #region 結果リスト
    /// <summary>
    /// 結果リスト
    /// </summary>
    public ObservableCollection<NamedAPIResource> Results { get; set; } = [];
    #endregion

    #region 選択中アイテム
    /// <summary>
    /// 選択中アイテム
    /// </summary>
    public NamedAPIResource? SelectedItem { get; set; }
    #endregion

    #region エンドポイント
    /// <summary>
    /// エンドポイント
    /// </summary>
    private EndPointAttribute _endPoint;
    #endregion

    #region 情報ウィンドウの型
    /// <summary>
    /// 情報ウィンドウの型
    /// </summary>
    private Type _infoWindowType;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="attr">エンドポイント</param>
    /// <param name="infoFormType">情報ウィンドウの型</param>
    public NamedAPIResourceListViewModel(EndPointAttribute attr, Type infoWindowType)
    {
        _endPoint = attr;
        _infoWindowType = infoWindowType;
    }
    #endregion
}
