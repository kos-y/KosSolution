using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Games.VersionGroups;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// バージョングループ
/// </summary>
public partial class VersionGroupInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public VersionGroupInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region generation info Click
    /// <summary>
    /// generation info Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GenerationInfoButton_Click(object sender, EventArgs e)
    {
        object? tag = GenerationInfoButton.Tag;
        if (tag is null) {
            return;
        }

        if (tag is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using GenerationInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region move_learn_methods DataGridView CellClick
    /// <summary>
    /// move_learn_methods DataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveLearnMethodsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (MoveLearnMethodsDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (MoveLearnMethodsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }
    }
    #endregion

    #region move_learn_methods DataGridView CellDoubleClick
    /// <summary>
    /// move_learn_methods DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        MoveLearnMethodsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (MoveLearnMethodsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }
    }
    #endregion

    #region pokedexes DataGridView CellClick
    /// <summary>
    /// pokedexes DataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokedexesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (PokedexesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (PokedexesDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using PokedexInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region pokedexes DataGridView CellDoubleClick
    /// <summary>
    /// pokedexes DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokedexesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (PokedexesDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using PokedexInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region versions DataGridView CellClick
    /// <summary>
    /// versions DataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (VersionsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (VersionsDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region versions DataGridView CellDoubleClick
    /// <summary>
    /// versions DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (VersionsDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
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


    // メソッド

    #region データの表示
    /// <summary>
    /// データの表示
    /// </summary>
    /// <param name="url">URL</param>
    void SetData(string url)
    {
        VersionGroup? vg = VersionGroup.GetVersionGroup(url);
        if (vg is null) {
            return;
        }

        IdLabel.Text = $"{vg.Id}";
        NameLabel.Text = vg.Name ?? string.Empty;
        OrderLabel.Text = $"{vg.Order}";
        GenerationLabel.Text = vg.Generation?.Name ?? string.Empty;
        GenerationInfoButton.Tag = vg.Generation;
        MoveLearnMethodsDataGridView.AutoGenerateColumns = false;
        MoveLearnMethodsDataGridView.DataSource = vg.MoveLearnMethods;
        PokedexesDataGridView.AutoGenerateColumns = false;
        PokedexesDataGridView.DataSource = vg.Pokedexes;
        RegionsDataGridView.AutoGenerateColumns = false;
        RegionsDataGridView.DataSource = vg.Regions;
        VersionsDataGridView.AutoGenerateColumns = false;
        VersionsDataGridView.DataSource = vg.Versions;
    }
    #endregion
}
