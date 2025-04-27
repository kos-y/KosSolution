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

    #region ���݂̂̍d�� �ڍ� �N���b�N
    /// <summary>
    /// ���݂̂̍d�� �ڍ� �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FirmnessDetailButton_Click(object sender, EventArgs e)
    {
        if (FirmnessDetailButton.Tag is null) {
            return;
        }

        if (FirmnessDetailButton.Tag is not NamedAPIResource api) {
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

    #region �A�C�e�� �ڍ� �N���b�N
    /// <summary>
    /// �A�C�e�� �ڍ� �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemDetailButton_Click(object sender, EventArgs e)
    {
        if (ItemDetailButton.Tag is null) {
            return;
        }

        if (ItemDetailButton.Tag is not NamedAPIResource api) {
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

        if (FlavorDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (FlavorDataGridView.Rows[e.RowIndex].DataBoundItem is not BerryFlavorMap bfm) {
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

        if (FlavorDataGridView.Rows[e.RowIndex].DataBoundItem is not BerryFlavorMap bfm) {
            return;
        }

        if (bfm?.Flavor?.Url is null) {
            return;
        }

        using BerryFlavorInfoForm form = new(bfm.Flavor.Url);
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
        Berry? berry = Berry.GetBerry(url);
        if (berry is null) {
            return;
        }

        Tag = berry;
        IdTextBox.Text = $"{berry.Id}";
        NameTextBox.Text = berry.Name;
        GrowthTimeTextBox.Text = $"{berry.GrowthTime}";
        MaxHarvestTextBox.Text = $"{berry.MaxHarvest}";
        NaturalGiftPowerTextBox.Text = $"{berry.NaturalGiftPower}";
        SizeTextBox.Text = $"{berry.Size}";
        SmoothnessTextBox.Text = $"{berry.Smoothness}";
        SoilDrynessTextBox.Text = $"{berry.SoilDryness}";
        FirmnessTextBox.Text = $"{berry.Firmness}";
        FirmnessDetailButton.Tag = berry.Firmness;
        FlavorDataGridView.AutoGenerateColumns = false;
        FlavorDataGridView.DataSource = berry.Flavors;
        ItemTextBox.Text = berry.Item?.Name ?? string.Empty;
        ItemDetailButton.Tag = berry.Item;
        NaturalGiftTypeTextBox.Text = berry.NaturalGiftType?.Name ?? string.Empty;
        NaturalGiftTypeDetailButton.Tag = berry.NaturalGiftType;
    }
    #endregion
}
