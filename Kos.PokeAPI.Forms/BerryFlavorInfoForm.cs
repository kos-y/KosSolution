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


    // 静的メソッド

    #region 画面の表示
    /// <summary>
    /// 画面の表示
    /// </summary>
    /// <param name="owner"></param>
    /// <param name="url"></param>
    public static void Show(IWin32Window owner, string url)
    {
        using BerryFlavorInfoForm form = new(url);

        _ = form.ShowDialog(owner);
    }
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

    #region Load
    /// <summary>
    /// Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BerryFlavorInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region berries CellClick
    /// <summary>
    /// berries CellClick
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

    #region berries CellDoubleClick
    /// <summary>
    /// berries CellDoubleClick
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

    #region ContestType Click
    /// <summary>
    /// ContestType Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestTypeInfoButton_Click(object sender, EventArgs e)
    {
        object? tag = ContestTypeInfoButton.Tag;
        if (tag is null) {
            return;
        }

        if (tag is not NamedAPIResource r) {
            return;
        }

        if (r.Url is null) {
            return;
        }

        ContestTypeInfoForm form = new(r.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region names CellClick
    /// <summary>
    /// names CellClick
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

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name item) {
            return;
        }

        if (item.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(item.Language.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region namaes CellDoubleClick
    /// <summary>
    /// namaes CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NamesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name item) {
            return;
        }

        if (item.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(item.Language.Url);
        _ = form.ShowDialog(this);
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
        IdLabel.Text = $"{bf.Id}";
        NameLabel.Text = bf.Name;
        BerriesDataGridView.AutoGenerateColumns = false;
        BerriesDataGridView.DataSource = bf.Berries;
        ContestTypeLabel.Text = $"{bf.ContestType?.Name}";
        ContestTypeInfoButton.Tag = bf.ContestType;
        NamesDataGridView.DataSource = bf.Names;
    }
    #endregion
}
