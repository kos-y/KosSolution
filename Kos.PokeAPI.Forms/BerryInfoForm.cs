using Kos.Core.Forms;
using Kos.PokeAPI.Berries.Berries;
using Kos.PokeAPI.Berries.BerryFlavors;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// �؂̎���� �t�H�[��
/// </summary>
public partial class BerryInfoForm : Form
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
    public BerryInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region ���[�h
    /// <summary>
    /// ���[�h
    /// </summary>
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
    private void BerryInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region ���݂̂̍d�� �N���b�N
    /// <summary>
    /// ���݂̂̍d�� �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FirmnessButton_Click(object sender, EventArgs e)
    {
        if (FirmnessButton.Tag is null) {
            return;
        }

        if (FirmnessButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (string.IsNullOrWhiteSpace(api.Url)) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using BerryFirmnessInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region �A�C�e�� �N���b�N
    /// <summary>
    /// �A�C�e�� �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemButton_Click(object sender, EventArgs e)
    {
        if (ItemButton.Tag is null) {
            return;
        }

        if (ItemButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region �� �Z���N���b�N
    /// <summary>
    /// �� �Z���N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FlavorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (FlavorsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (FlavorsDataGridView.Rows[e.RowIndex].DataBoundItem is not BerryFlavorMap bfm) {
            return;
        }

        if (bfm?.Flavor?.Url is null) {
            return;
        }

        using BerryFlavorInfoForm form = new(bfm.Flavor.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region �� �Z���_�u���N���b�N
    /// <summary>
    /// �� �Z���_�u���N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FlavorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (FlavorsDataGridView.Rows[e.RowIndex].DataBoundItem is not BerryFlavorMap bfm) {
            return;
        }

        if (bfm?.Flavor?.Url is null) {
            return;
        }

        using BerryFlavorInfoForm form = new(bfm.Flavor.Url);
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
    /// <param name="sender">�C�x���g�����I�u�W�F�N�g</param>
    /// <param name="e">�C�x���g����</param>
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
        Berry? berry = Berry.GetResource(url);
        if (berry is null) {
            return;
        }

        Tag = berry;
        FormsHelper.SetData(berry.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(berry.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(berry.GrowthTime, GrowthTimeCaptionLabel, GrowthTimeTextBox);
        FormsHelper.SetData(berry.MaxHarvest, MaxHarvestCaptionLabel, MaxHarvestTextBox);
        FormsHelper.SetData(berry.NaturalGiftPower, NaturalGiftPowerCaptionLabel, NaturalGiftPowerTextBox);
        FormsHelper.SetData(berry.Size, SizeCaptionLabel, SizeTextBox);
        FormsHelper.SetData(berry.Smoothness, SmoothnessCaptionLabel, SmoothnessTextBox);
        FormsHelper.SetData(berry.Firmness, FirmnessButton, FirmnessTextBox);
        FormsHelper.SetData(berry.Flavors, FlavorsCaptionLabel, FlavorsDataGridView);
        FormsHelper.SetData(berry.Item, ItemButton, ItemTextBox);
        FormsHelper.SetData(berry.NaturalGiftType, NaturalGiftTypeButton, NaturalGiftTypeTextBox);
    }
    #endregion
}
