using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Items.ItemCategories;
using Kos.PokeAPI.Locations.Locations;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 場所
/// </summary>
public partial class LocationInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public LocationInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region 地域 詳細 クリック
    /// <summary>
    /// 地域 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RegionDetailButton_Click(object sender, EventArgs e)
    {
        if (RegionDetailButton.Tag is null) {
            return;
        }

        if (RegionDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using RegionInfoForm form = new(api.Url);
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

    #region 世代ごとのゲームインデックス セルクリック
    /// <summary>
    /// 世代ごとのゲームインデックス セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GameIndiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (GameIndiceDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (GameIndiceDataGridView.Rows[e.RowIndex].DataBoundItem is not GenerationGameIndex ggi) {
            return;
        }

        using GenerationGameIndexInfoForm form = new(ggi);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 世代ごとのゲームインデックス セルダブルクリック
    /// <summary>
    /// 世代ごとのゲームインデックス セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GameIndiceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (GameIndiceDataGridView.Rows[e.RowIndex].DataBoundItem is not GenerationGameIndex ggi) {
            return;
        }

        using GenerationGameIndexInfoForm form = new(ggi);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region エリア セルクリック
    /// <summary>
    /// エリア セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AreasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (AreasDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (AreasDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using LocationAreaInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region エリア セルダブルクリック
    /// <summary>
    /// エリア セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AreasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (AreasDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using LocationAreaInfoForm form = new(api.Url);
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

    #region データを画面に設定
    /// <summary>
    /// データを画面に設定
    /// </summary>
    /// <param name="url"></param>
    private void SetData(string url)
    {
        Kos.PokeAPI.Locations.Locations.Location? l
            = Kos.PokeAPI.Locations.Locations.Location.GetResource(url);
        if (l is null) {
            return;
        }

        Tag = l;
        IdTextBox.Text = $"{l.Id}";
        NameTextBox.Text = l.Name;
        RegionTextBox.Text = l.Region?.Name ?? string.Empty;
        RegionDetailButton.Tag = l.Region;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = l.Names;
        GameIndiceDataGridView.AutoGenerateColumns = false;
        GameIndiceDataGridView.DataSource = l.GameIndices;
        AreasDataGridView.AutoGenerateColumns = false;
        AreasDataGridView.DataSource = l.Areas;
    }
    #endregion
}
