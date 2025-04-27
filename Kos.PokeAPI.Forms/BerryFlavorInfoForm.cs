using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Berries.BerryFirmnesses;
using Kos.PokeAPI.Berries.BerryFlavors;
using Kos.PokeAPI.Utility.CommonModels;
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// Berry Flavor Form
/// </summary>
public partial class BerryFlavorInfoForm : Form
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
    public BerryFlavorInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region ロード
    /// <summary>
    /// ロード
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BerryFlavorInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region きのみ セルクリック
    /// <summary>
    /// きのみ セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BerriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        DataGridViewCell cell = BerriesDataGridView[e.ColumnIndex, e.RowIndex];
        if (cell is not DataGridViewButtonCell) {
            return;
        }

        if (BerriesDataGridView.Rows[e.RowIndex].DataBoundItem is not FlavorBerryMap fbm) {
            return;
        }

        if (fbm?.Berry?.Url is null) {
            return;
        }

        using BerryInfoForm form = new(fbm.Berry.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region きのみ セルダブルクリック
    /// <summary>
    /// きのみ セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BerriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (BerriesDataGridView.Rows[e.RowIndex].DataBoundItem is not FlavorBerryMap item) {
            return;
        }

        if (item?.Berry?.Url is null) {
            return;
        }

        using BerryInfoForm form = new(item.Berry.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region コンテストの種類 クリック
    /// <summary>
    /// コンテストの種類 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestTypeDetailButton_Click(object sender, EventArgs e)
    {
        if (ContestTypeDetailButton.Tag is null) {
            return;
        }

        if (ContestTypeDetailButton.Tag is not NamedAPIResource r) {
            return;
        }

        if (r.Url is null) {
            return;
        }

        ContestTypeInfoForm form = new(r.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの名前 セルクリック
    /// <summary>
    /// 言語ごとの名前 セルクリック
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

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        using NameInfoForm form = new(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの名前 セルダブルクリック
    /// <summary>
    /// 言語ごとの名前 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NamesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        using NameInfoForm form = new(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 閉じる クリック
    /// <summary>
    /// 閉じる クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
        BerryFlavor? bf = BerryFlavor.GetBerryFlavor(url);
        if (bf is null) {
            return;
        }

        Tag = bf;
        IdTextBox.Text = $"{bf.Id}";
        NameTextBox.Text = bf.Name;
        BerriesDataGridView.AutoGenerateColumns = false;
        BerriesDataGridView.DataSource = bf.Berries;
        ContestTypeTextBox.Text = bf.ContestType?.Name ?? string.Empty;
        ContestTypeDetailButton.Tag = bf.ContestType;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = bf.Names;
    }
    #endregion
}
