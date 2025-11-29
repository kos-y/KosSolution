using System.Reflection;
using System.Security.Policy;
using Kos.PokeAPI.Attribute;
using Kos.PokeAPI.ResourceLists;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms.ResourceLists;

/// <summary>
/// 名前付きAPIリソースリスト フォーム
/// </summary>
public partial class NamedAPIResourceListForm : Form
{
    // フィールド

    #region 定数 name 列番号
    /// <summary>
    /// name 列番号
    /// </summary>
    private const int ColumnName = 1;
    #endregion

    #region 定数 url 列番号
    /// <summary>
    /// url 列番号
    /// </summary>
    private const int ColumnUrl = 2;
    #endregion

    #region 定数 Info 列番号
    /// <summary>
    /// Info 列番号
    /// </summary>
    private const int ColumnInfo = 3;
    #endregion

    #region エンドポイント Attribute
    /// <summary>
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

    #region 名前付きAPIリソースリスト
    /// <summary>
    /// 名前付きAPIリソースリスト
    /// </summary>
    private NamedAPIResourceList? _resourceList = null;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="attr">エンドポイント Attribute</param>
    /// <param name="infoFormType">情報 Form 型</param>
    public NamedAPIResourceListForm(EndPointAttribute attr, Type infoFormType)
    {
        InitializeComponent();

        _endPointAttribute = attr;
        _infoFormType = infoFormType;
    }
    #endregion

    #region ロード
    /// <summary>
    /// ロード
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void NamedAPIResourceListForm_Load(object sender, EventArgs e)
    {
        SetDataGrid(_endPointAttribute, NamedAPIResourceListDataGridView);
    }
    #endregion

    #region 名前付きAPIリソースリストDataGridView CellClick
    /// <summary>
    /// 名前付きAPIリソースリストDataGridView CellClick
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void
        NamedAPIResourceListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        DataGridViewCell cell = NamedAPIResourceListDataGridView[e.ColumnIndex, e.RowIndex];
        if (cell is not DataGridViewButtonCell) {
            return;
        }

        ShowInfo($"{NamedAPIResourceListDataGridView[ColumnUrl, e.RowIndex].Value}");
    }
    #endregion

    #region 名前付きAPIリソースリストDataGridView CellDoubleClick
    /// <summary>
    /// 名前付きAPIリソースリストDataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void
        NamedAPIResourceListDataGridView_CellDoubleClick(
            object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        ShowInfo($"{NamedAPIResourceListDataGridView[ColumnUrl, e.RowIndex].Value}");
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

        SetDataGrid(_resourceList.Previous, NamedAPIResourceListDataGridView);
    }
    #endregion

    #region Next Click
    /// <summary>
    /// Next Click
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void NextPageButton_Click(object sender, EventArgs e)
    {
        if (_resourceList?.Next is null) {
            return;
        }

        SetDataGrid(_resourceList.Next, NamedAPIResourceListDataGridView);
    }
    #endregion

    #region Open Click
    /// <summary>
    /// Open Click
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void OpenButton_Click(object sender, EventArgs e)
    {
        DataGridViewRow? row = NamedAPIResourceListDataGridView.CurrentRow;

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
        SetDataGrid(NamedAPIResourceList.GetNamedAPIResourceList(attr.EndPoint), dgv);
    }

    /// <summary>
    /// データグリッドへ表示
    /// </summary>
    /// <param name="url">URL</param>
    /// <param name="dgv">DataGridView</param>
    private void SetDataGrid(string url, DataGridView dgv)
    {
        SetDataGrid(NamedAPIResourceList.GetNamedAPIResourceListUrl(url), dgv);
    }

    /// <summary>
    /// DataGridViewへデータの設定
    /// </summary>
    /// <param name="list">名前付きAPIリソースリスト</param>
    /// <param name="dgv">DataGridView</param>
    private void SetDataGrid(NamedAPIResourceList list, DataGridView dgv)
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
