using Kos.PokeAPI.Berries.Berries;
using Kos.PokeAPI.Berries.BerryFlavors;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Berries.Forms;

/// <summary>
/// 木の実情報 フォーム
/// </summary>
public partial class BerryInfoForm : Form
{

    // フィールド

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public BerryInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region Form Load
    /// <summary>
    /// Form Load
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void BerryInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region firmness Info Click
    /// <summary>
    /// firmness Info Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FirmnessInfoButton_Click(object sender, EventArgs e)
    {
        object? tag = FirmnessInfoButton.Tag;
        if (tag is null) {
            return;
        }

        if (tag is not NamedAPIResource r) {
            return;
        }

        if (string.IsNullOrWhiteSpace(r.Url)) {
            return;
        }

        using BerryFirmnessInfoForm form = new(r.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region Flavor CellClick
    /// <summary>
    /// Flavor CellClick
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

    #region flavor CellDoubleClick
    /// <summary>
    /// flavor CellDoubleClick
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

    #region Close Click
    /// <summary>
    /// Close Click
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void CloseButton_Click(object sender, EventArgs e)
    {
        Close();
    }
    #endregion

    #region データの表示
    /// <summary>
    /// データの表示
    /// </summary>
    /// <param name="url">URL</param>
    private void SetData(string url)
    {
        Berry? berry = Berry.GetBerry(url);
        if (berry is null) {
            return;
        }

        Tag = berry;
        IdLabel.Text = $"{berry.Id}";
        NameLabel.Text = berry.Name;
        GrowthTimeLabel.Text = $"{berry.GrowthTime}";
        MaxHarvestLabel.Text = $"{berry.MaxHarvest}";
        NaturalGiftPowerLabel.Text = $"{berry.NaturalGiftPower}";
        SizeLabel.Text = $"{berry.Size}";
        SmoothnessLabel.Text = $"{berry.Smoothness}";
        SoilDrynessLabel.Text = $"{berry.SoilDryness}";
        FirmnessLabel.Text = berry.Firmness?.Name ?? string.Empty;
        FirmnessInfoButton.Tag = berry.Firmness;
        FlavorDataGridView.DataSource = berry.Flavors;
        ItemLabel.Text = berry.Item?.Name ?? string.Empty;
        ItemInfoButton.Tag = berry.Item;
        NaturalGiftTypeLabel.Text = berry.NaturalGiftType?.Name ?? string.Empty;
        NaturalGiftTypeInfoButton.Tag = berry.NaturalGiftType;
    }
    #endregion
}
