using Kos.Core.Forms;
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

    #region ���݂̖̂� �N���b�N
    /// <summary>
    /// ���݂̖̂� �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BerryFlavorButton_Click(object sender, EventArgs e)
    {
        if (BerryFlavorButton.Tag is null) {
            return;
        }

        if (BerryFlavorButton.Tag is not NamedAPIResource api) {
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

    #region �v���p�e�B �N���b�N
    /// <summary>
    /// �v���p�e�B �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PropertyButton_Click(object sender, EventArgs e)
    {
        using PropertyGridForm form = new(Tag);
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
        ContestType? type = ContestType.GetContestType(url);
        if (type is null) {
            return;
        }

        Tag = type;
        FormsHelper.SetData(type.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(type.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(type.BerryFlavor, BerryFlavorButton, BerryFlavorTextBox);
        FormsHelper.SetData(type.Names, NameCaptionLabel, NamesDataGridView);
    }
    #endregion
}
