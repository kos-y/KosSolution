using Kos.PokeAPI.Berries.Berries;
using Kos.PokeAPI.Berries.BerryFlavors;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

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

    #region ロード
    /// <summary>
    /// ロード
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void BerryInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region きのみの硬さ 詳細 クリック
    /// <summary>
    /// きのみの硬さ 詳細 クリック
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

    #region アイテム 詳細 クリック
    /// <summary>
    /// アイテム 詳細 クリック
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

    #region 味 セルクリック
    /// <summary>
    /// 味 セルクリック
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

    #region 味 セルダブルクリック
    /// <summary>
    /// 味 セルダブルクリック
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

    #region 閉じる クリック
    /// <summary>
    /// 閉じる クリック
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
        FirmnessDetailButton.Tag = berry.Firmness;
        FlavorDataGridView.AutoGenerateColumns = false;
        FlavorDataGridView.DataSource = berry.Flavors;
        ItemLabel.Text = berry.Item?.Name ?? string.Empty;
        ItemDetailButton.Tag = berry.Item;
        NaturalGiftTypeLabel.Text = berry.NaturalGiftType?.Name ?? string.Empty;
        NaturalGiftTypeInfoButton.Tag = berry.NaturalGiftType;
    }
    #endregion
}
