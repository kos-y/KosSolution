using Kos.Core.Forms;
using Kos.PokeAPI.Contests.ContestEffects;
using Kos.PokeAPI.Contests.ContestTypes;
using Kos.PokeAPI.Forms.Utility.CommonModels;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// �R���e�X�g����
/// </summary>
public partial class ContestEffectInfoForm : Form
{
    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url;
    #endregion

    #region �R���X�g���N�^
    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    /// <param name="url">URL</param>
    public ContestEffectInfoForm(string url)
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
    private void ContestEffectInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region ���� �Z���N���b�N
    /// <summary>
    /// ���� �Z���N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectEntriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not Effect effect) {
            return;
        }

        using EffectInfoForm form = new(effect);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region  ���� �Z���_�u���N���b�N
    /// <summary>
    /// ���� �Z���_�u���N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EffectEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not Effect effect) {
            return;
        }

        using EffectInfoForm form = new(effect);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region �t���[�o�[�e�L�X�g �Z���N���b�N
    /// <summary>
    /// �t���[�o�[�e�L�X�g �Z���N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        FlavorTextEntriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView[e.ColumnIndex, e.RowIndex] is not
                DataGridViewButtonCell) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not FlavorText ft) {
            return;
        }

        using FlavorTextInfoForm form = new(ft);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region �t���[�o�[�e�L�X�g �Z���_�u���N���b�N
    /// <summary>
    /// �t���[�o�[�e�L�X�g �Z���_�u���N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        FlavorTextEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not FlavorText ft) {
            return;
        }

        using FlavorTextInfoForm form = new(ft);
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
        if (Tag is null) {
            return;
        }

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
        ContestEffect? effect = ContestEffect.GetContestEffect(url);
        if (effect is null) {
            return;
        }

        Tag = effect;
        FormsHelper.SetData(effect.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(effect.Appeal, AppealCaptionLabel, AppealTextBox);
        FormsHelper.SetData(effect.Jam, JamCaptionLabel, JamTextBox);
        FormsHelper.SetData(effect.EffectEntries, EffectEntriesCaptionLabel, EffectEntriesDataGridView);
        FormsHelper.SetData(effect.FlavorTextEntries, FlavorTextEntriesCaptionLabel, FlavorTextEntriesDataGridView);
    }
    #endregion
}
