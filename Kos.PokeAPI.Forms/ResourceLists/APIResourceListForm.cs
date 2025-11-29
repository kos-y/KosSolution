using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Attribute;
using Kos.PokeAPI.ResourceLists;

namespace Kos.PokeAPI.Forms.ResourceLists;

/// <summary>
/// APIリソースリスト Form
/// </summary>
public partial class APIResourceListForm : Form
{
    // フィールド

    #region 定数 url 列番号
    /// <summary>
    /// url 列番号
    /// </summary>
    private const int ColumnUrl = 1;
    #endregion

    #region 定数 Info 列番号
    /// <summary>
    /// Info 列番号
    /// </summary>
    private const int ColumnInfo = 2;
    #endregion

    #region エンドポイント Attribute
    /// <summary>W
    /// エンドポイント Attribute
    /// </summary>
    private readonly EndPointAttribute _endPointAttribute;
    #endregion

    #region 情報 Form 型
    /// <summary>
    /// 情報 Form 型
    /// </summary>
    private readonly Type _infoFormType;
    #endregion

    #region APIリソースリスト
    /// <summary>
    /// APIリソースリスト
    /// </summary>
    private APIResourceList? _resourceList = null;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="attr">エンドポイント Attribute</param>
    /// <param name="infoFormType">情報フォーム型</param>
    public APIResourceListForm(EndPointAttribute attr, Type infoFormType)
    {
        InitializeComponent();

        _endPointAttribute = attr;
        _infoFormType = infoFormType;
    }
    #endregion

    #region Load
    /// <summary>
    /// Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void APIResourceListForm_Load(object sender, EventArgs e)
    {
        SetDataGrid(_endPointAttribute, APIResourceListDataGridView);
    }
    #endregion

    #region APIリソースリストDataGridView CellClick
    /// <summary>
    /// APIリソースリストDataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void APIResourceListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        DataGridViewCell cell = APIResourceListDataGridView[e.ColumnIndex, e.RowIndex];
        if (cell is not DataGridViewButtonCell) {
            return;
        }

        ShowInfo($"{APIResourceListDataGridView[ColumnUrl, e.RowIndex].Value}");
    }
    #endregion

    #region APIリソースリストDataGridView CellDoubleClick
    /// <summary>
    /// APIリソースリストDataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        APIResourceListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        ShowInfo($"{APIResourceListDataGridView[ColumnUrl, e.RowIndex].Value}");
    }
    #endregion

    #region Previous Click
    /// <summary>
    /// Previous Click
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void PrevPageButton_Click(object sender, EventArgs e)
    {
        if (_resourceList?.Previous is null) {
            return;
        }

        SetDataGrid(_resourceList.Previous, APIResourceListDataGridView);
    }
    #endregion

    #region Next Click
    /// <summary>
    /// Next Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NextPageButton_Click(object sender, EventArgs e)
    {
        if (_resourceList?.Next is null) {
            return;
        }

        SetDataGrid(_resourceList.Next, APIResourceListDataGridView);
    }
    #endregion

    #region Open Click
    /// <summary>
    /// Open Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OpenButton_Click(object sender, EventArgs e)
    {
        DataGridViewRow? row = APIResourceListDataGridView.CurrentRow;

        ShowInfo($"{row?.Cells[ColumnUrl].Value}");
    }
    #endregion

    #region Close Click
    /// <summary>
    /// Close Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CloseButton_Click(object sender, EventArgs e)
    {
        Close();
    }
    #endregion

    #region データグリッドへ表示
    /// <summary>
    /// データグリッドへ表示
    /// </summary>
    /// <param name="attr">エンドポイントAttribute</param>
    /// <param name="dgv">DataGridView</param>
    private void SetDataGrid(EndPointAttribute attr, DataGridView dgv)
    {
        SetDataGrid(APIResourceList.GetAPIResourceList(attr.EndPoint), dgv);
    }

    /// <summary>
    /// データグリッドへ表示
    /// </summary>
    /// <param name="url">URL</param>
    /// <param name="dgv">DataGridView</param>
    private void SetDataGrid(string url, DataGridView dgv)
    {
        SetDataGrid(APIResourceList.GetAPIResourceListUrl(url), dgv);
    }

    /// <summary>
    /// DataGridViewへデータの設定
    /// </summary>
    /// <param name="list">APIリソースリスト</param>
    /// <param name="dgv">DataGridView</param>
    private void SetDataGrid(APIResourceList list, DataGridView dgv)
    {
        _resourceList = list;
        dgv.ClearSelection();

        if (list.Results is not null) {
            dgv.DataSource = list.Results;
        }
    }
    #endregion

    #region Info フォームのモーダル表示
    /// <summary>
    /// Info フォームのモーダル表示
    /// </summary>
    /// <param name="url">URL</param>
    private void ShowInfo(string url)
    {
        object? form = Activator.CreateInstance(_infoFormType, url);
        if (form is null) {
            return;
        }

        MethodInfo? showDialog
            = _infoFormType.GetMethod(nameof(ShowDialog), [typeof(IWin32Window)]);
        if (showDialog is null) {
            return;
        }

        MethodInfo? dispose = _infoFormType?.GetMethod(nameof(Dispose));
        if (dispose is null) {
            return;
        }

        _ = showDialog.Invoke(form, [this]);
        dispose.Invoke(form, null);
    }
    #endregion
}
