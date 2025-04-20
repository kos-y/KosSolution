using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Berries.Berries;
using Kos.PokeAPI.Berries.BerryFirmnesses;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 木の実の硬さ情報フォーム
/// </summary>
public partial class BerryFirmnessInfoForm : Form
{
    // フィールド

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url = string.Empty;
    #endregion

    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public BerryFirmnessInfoForm(string url)
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
    private void BerryFirmnessInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region Berries CellClick
    /// <summary>
    /// Berries CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BerriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (BerriesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (BerriesDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource berry) {
            return;
        }

        if (berry.Url is null) {
            return;
        }

        using BerryInfoForm form = new(berry.Url);
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

        if (BerriesDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource berry) {
            return;
        }

        if (berry.Url is null) {
            return;
        }

        using BerryInfoForm form = new(berry.Url);
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

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        if (name?.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(name.Language.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region names CellDoubleClick
    /// <summary>
    /// names CellDoubleClick
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

        if (name?.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(name.Language.Url);
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
        BerryFirmness? bf = BerryFirmness.GetBerryFirmness(url);
        if (bf is null) {
            return;
        }

        Tag = bf;
        IdLabel.Text = $"{bf.Id}";
        NameLabel.Text = bf.Name;
        BerriesDataGridView.AutoGenerateColumns = false;
        BerriesDataGridView.DataSource = bf.Berries;
        NamesDataGridView.DataSource = bf.Names;
    }
    #endregion
}
