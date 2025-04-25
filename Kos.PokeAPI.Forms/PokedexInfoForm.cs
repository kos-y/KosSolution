using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Games.Generations;
using Kos.PokeAPI.Games.Pokedexes;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモン図鑑
/// </summary>
public partial class PokedexInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public PokedexInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region Descriptions DataGridView CellClick
    /// <summary>
    /// Descriptions DataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DescriptionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (DescriptionsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (DescriptionsDataGridView.Rows[e.RowIndex].DataBoundItem is not Description desc) {
            return;
        }

        if (desc?.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(desc.Language.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region Descriptions DataGridView CellDoubleClick
    /// <summary>
    /// Descriptions DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DescriptionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (DescriptionsDataGridView.Rows[e.RowIndex].DataBoundItem is not Description desc) {
            return;
        }

        if (desc?.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(desc.Language.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region names DataGridView CellClick
    /// <summary>
    /// names DataGridView CellClick
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

        using LanguageInfoForm languageInfoForm = new(name.Language.Url);
        _ = languageInfoForm.ShowDialog();
    }
    #endregion

    #region names DataGridView CellDoubleClick
    /// <summary>
    /// names DataGridView CellDoubleClick
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

        using LanguageInfoForm languageInfoForm = new(name.Language.Url);
        _ = languageInfoForm.ShowDialog();
    }
    #endregion

    #region version_group DataGridView CellClick
    /// <summary>
    /// version_group DataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (VersionGroupDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (VersionGroupDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region version_group DataGridView CellDoubleClick
    /// <summary>
    /// version_group DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        VersionGroupDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (VersionGroupDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new(api.Url);
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
    public void SetData(string url)
    {
        Pokedex? p = Pokedex.GetPokedex(url);
        if (p is null) {
            return;
        }

        IdLabel.Text = $"{p.Id}";
        NameLabel.Text = p.Name ?? string.Empty;
        IsMainSeriesLabel.Text = $"{p.IsMainSeries}";
        DescriptionsDataGridView.AutoGenerateColumns = false;
        DescriptionsDataGridView.DataSource = p.Descriptions;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = p.Names;
        PokemonEntriesDataGridView.AutoGenerateColumns = false;
        PokemonEntriesDataGridView.DataSource = p.PokemonEntries;
        RegionLabel.Text = p.Region?.Name ?? string.Empty;
        RegionInfoButton.Tag = p.Region;
        VersionGroupDataGridView.AutoGenerateColumns = false;
        VersionGroupDataGridView.DataSource = p.VersionGroups;
    }
    #endregion
}
