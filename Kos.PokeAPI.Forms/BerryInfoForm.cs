using Kos.Core.Forms;
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

    #region きのみの硬さ クリック
    /// <summary>
    /// きのみの硬さ クリック
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

    #region アイテム クリック
    /// <summary>
    /// アイテム クリック
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

    #region プロパティ クリック
    /// <summary>
    /// プロパティ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PropertyButton_Click(object sender, EventArgs e)
    {
        using PropertyGridForm form = new(Tag);
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
