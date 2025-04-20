using System.Reflection;
using System.Security.Policy;
using Kos.PokeAPI.Attribute;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.ResourceLists.Forms;

/// <summary>
/// ���O�t��API���\�[�X���X�g �t�H�[��
/// </summary>
public partial class NamedAPIResourceListForm : Form
{
    // �t�B�[���h

    #region �萔 name ��ԍ�
    /// <summary>
    /// name ��ԍ�
    /// </summary>
    private const int ColumnName = 1;
    #endregion

    #region �萔 url ��ԍ�
    /// <summary>
    /// url ��ԍ�
    /// </summary>
    private const int ColumnUrl = 2;
    #endregion

    #region �萔 Info ��ԍ�
    /// <summary>
    /// Info ��ԍ�
    /// </summary>
    private const int ColumnInfo = 3;
    #endregion

    #region �G���h�|�C���g Attribute
    /// <summary>
    /// �G���h�|�C���g Attribute
    /// </summary>
    private readonly EndPointAttribute _endPointAttribute;
    #endregion

    #region ��� Form �^
    /// <summary>
    /// ��� Form �^
    /// </summary>
    private readonly Type _infoFormType;
    #endregion

    #region ���O�t��API���\�[�X���X�g
    /// <summary>
    /// ���O�t��API���\�[�X���X�g
    /// </summary>
    private NamedAPIResourceList? _resourceList = null;
    #endregion


    // ���\�b�h

    #region �R���X�g���N�^
    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    /// <param name="attr">�G���h�|�C���g Attribute</param>
    /// <param name="infoFormType">��� Form �^</param>
    public NamedAPIResourceListForm(EndPointAttribute attr, Type infoFormType)
    {
        InitializeComponent();

        _endPointAttribute = attr;
        _infoFormType = infoFormType;
    }
    #endregion

    #region �t�H�[�� Load
    /// <summary>
    /// �t�H�[�� Load
    /// </summary>
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
    private void NamedAPIResourceListForm_Load(object sender, EventArgs e)
    {
        SetDataGrid(_endPointAttribute, NamedAPIResourceListDataGridView);
    }
    #endregion

    #region ���O�t��API���\�[�X���X�gDataGridView CellClick
    /// <summary>
    /// ���O�t��API���\�[�X���X�gDataGridView CellClick
    /// </summary>
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
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

    #region ���O�t��API���\�[�X���X�gDataGridView CellDoubleClick
    /// <summary>
    /// ���O�t��API���\�[�X���X�gDataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
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
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
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
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
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
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
    private void OpenButton_Click(object sender, EventArgs e)
    {
        DataGridViewRow row = NamedAPIResourceListDataGridView.CurrentRow;

        ShowInfo($"{row.Cells[ColumnUrl].Value}");
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

    #region �f�[�^�O���b�h�֕\��
    /// <summary>
    /// �f�[�^�O���b�h�֕\��
    /// </summary>
    /// <param name="attr">�G���h�|�C���gAttribute</param>
    /// <param name="dgv">DataGridView</param>
    private void SetDataGrid(EndPointAttribute attr, DataGridView dgv)
    {
        SetDataGrid(NamedAPIResourceList.GetNamedAPIResourceList(attr.EndPoint), dgv);
    }

    /// <summary>
    /// �f�[�^�O���b�h�֕\��
    /// </summary>
    /// <param name="url">URL</param>
    /// <param name="dgv">DataGridView</param>
    private void SetDataGrid(string url, DataGridView dgv)
    {
        SetDataGrid(NamedAPIResourceList.GetNamedAPIResourceListUrl(url), dgv);
    }

    /// <summary>
    /// DataGridView�փf�[�^�̐ݒ�
    /// </summary>
    /// <param name="list">���O�t��API���\�[�X���X�g</param>
    /// <param name="dgv">DataGridView</param>
    private void SetDataGrid(NamedAPIResourceList list, DataGridView dgv)
    {
        _resourceList = list;
        dgv.ClearSelection();
        dgv.Rows.Clear();

        if (list.Results is not null) {
            dgv.DataSource = list.Results;
        }
    }
    #endregion

    #region Info �t�H�[���̃��[�_���\��
    /// <summary>
    /// Info �t�H�[���̃��[�_���\��
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
