using Kos.PokeAPI.Contests.ContestTypes;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// Contest Type
/// </summary>
public partial class ContestTypeInfoForm : Form
{
    // �t�B�[���h

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url;
    #endregion


    // ���\�b�h

    #region �R���X�g���N�^
    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    /// <param name="url">URL</param>
    public ContestTypeInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region ���[�h
    /// <summary>
    /// ���[�h
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestTypeInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region ���݂̖̂� �ڍ� �N���b�N
    /// <summary>
    /// ���݂̖̂� �ڍ� �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BerryFlavorDetailButton_Click(object sender, EventArgs e)
    {
        if (BerryFlavorDetailButton.Tag is null) {
            return;
        }

        if (BerryFlavorDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        BerryFlavorInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ���ꂲ�Ƃ̖��O �Z���N���b�N
    /// <summary>
    /// ���ꂲ�Ƃ̖��O �Z���N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NamesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (NamesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not ContestName cn) {
            return;
        }

        using ContestNameInfoForm form = new(cn);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ���ꂲ�Ƃ̖��O �Z���_�u���N���b�N
    /// <summary>
    /// ���ꂲ�Ƃ̖��O �Z���_�u���N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NamesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not ContestName cn) {
            return;
        }

        using ContestNameInfoForm form = new(cn);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ���� �N���b�N
    /// <summary>
    /// ���� �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CloseButton_Click(object sender, EventArgs e)
    {
        Close();
    }
    #endregion

    #region �f�[�^�̕\��
    /// <summary>
    /// �f�[�^�̕\��
    /// </summary>
    /// <param name="url">URL</param>
    private void SetData(string url)
    {
        ContestType? ct = ContestType.GetContestType(url);
        if (ct is null) {
            return;
        }

        Tag = ct;
        IdTextBox.Text = $"{ct.Id}";
        NameTextBox.Text = ct.Name;
        BerryFlavorTextBox.Text = ct.BerryFlavor.Name ?? string.Empty;
        BerryFlavorDetailButton.Tag = ct.BerryFlavor;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = ct.Names;
    }
    #endregion
}
