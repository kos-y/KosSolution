using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Kos.Core.WPF;
using Kos.PokeAPI;
using Kos.PokeAPI.Attribute;

namespace AppPokeAPIViewerWPF;

/// <summary>
/// メインウィンドウ ViewModel
/// </summary>
public class MainWindowViewModel : NotifyPropertyChanged
{
    #region リソースカテゴリ アイテム群
    /// <summary>
    /// リソースカテゴリ アイテム群
    /// </summary>
    public ObservableCollection<ResourceCategoryAttribute> ResourceCategoryItems { get; set; } = [];
    #endregion

    #region リソースカテゴリ 選択中アイテム
    /// <summary>
    /// リソースカテゴリ 選択中アイテム
    /// </summary>
    public ResourceCategoryAttribute? SelectedResourceCategoryItem { get; set; }
    #endregion

    #region エンドポイント アイテム群
    /// <summary>
    /// エンドポイント アイテム群
    /// </summary>
    public ObservableCollection<EndPointAttribute> EndPointItems { get; set; } = [];
    #endregion

    #region エンドポイント 選択中アイテム
    /// <summary>
    /// エンドポイント 選択中アイテム
    /// </summary>
    public EndPointAttribute? SelectedEndPointItme { get; set; }
    #endregion


    // コマンド

    #region リソースカテゴリ 選択変更イベント コマンド
    /// <summary>
    /// リソースカテゴリ 選択変更イベント コマンド
    /// </summary>
    public Command ResourceCategorySelectionChangedCommand { get; set; }
    #endregion

    #region エンドポイント 選択コマンド
    /// <summary>
    /// エンドポイント 選択コマンド
    /// </summary>
    public Command OpenEndPointCommand { get; set; }
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MainWindowViewModel()
    {
        // リソースカテゴリの設定
        SetResourceCategory();

        // コマンドの設定
        ResourceCategorySelectionChangedCommand = new Command(ResourceCategoryListSelectionChanged);
        OpenEndPointCommand = new Command(OpenEndPoint);
    }
    #endregion

    #region リソースカテゴリ 選択変更イベント
    /// <summary>
    /// リソースカテゴリ 選択変更イベント
    /// </summary>
    private void ResourceCategoryListSelectionChanged()
    {
        if (SelectedResourceCategoryItem is null) {
            SelectedEndPointItme = null;
            EndPointItems.Clear();
            return;
        }

        SetEndPoint(SelectedResourceCategoryItem);
    }
    #endregion

    /// <summary>
    /// 洗濯したエンドポイントで開く
    /// </summary>
    private void OpenEndPoint()
    {
        if (SelectedEndPointItme is null) {
            return;
        }
    }

    #region リソースカテゴリの設定
    /// <summary>
    /// リソースカテゴリの設定
    /// </summary>
    private void SetResourceCategory()
    {
        Type type = typeof(ResourceCategory);

        foreach (ResourceCategory rc in Enum.GetValues(typeof(ResourceCategory))) {
            FieldInfo? fi = type.GetField(rc.ToString());
            if (fi is null) {
                continue;
            }

            ResourceCategoryAttribute? attr = fi.GetCustomAttribute<ResourceCategoryAttribute>();
            if (attr is null) {
                continue;
            }

            ResourceCategoryItems.Add(attr);
        }
    }
    #endregion

    #region エンドポイントの表示
    /// <summary>
    /// エンドポイントの表示
    /// </summary>
    /// <param name="rca">リソースカテゴリのAttribute</param>
    /// <param name="eplb">エンドポイントリストボックス</param>
    private void SetEndPoint(ResourceCategoryAttribute rca)
    {
        Type type = typeof(EndPoint);

        SelectedEndPointItme = null;
        EndPointItems.Clear();
        foreach (EndPoint ep in rca.EndPoints) {
            FieldInfo? fi = type.GetField(ep.ToString());
            if (fi is null) {
                continue;
            }

            EndPointAttribute? attr = fi.GetCustomAttribute<EndPointAttribute>();
            if (attr is null) {
                continue;
            }

            EndPointItems.Add(attr);
        }
    }
    #endregion
}
