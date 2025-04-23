using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Evolution.EvolutionTriggers;
using Kos.PokeAPI.Games.Generations;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 世代
/// </summary>
public partial class GenerationInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public GenerationInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
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

        if (name.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(name.Language.Url);
        _ = form.ShowDialog(this);
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

        if (name.Language?.Url is null) {
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
    public void SetData(string url)
    {
        Generation? g = Generation.GetGeneration(url);
        if (g is null) {
            return;
        }

        IdLabel.Text = $"{g.Id}";
        NameLabel.Text = g.Name ?? string.Empty;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = g.Names;
        AbilitiesDataGridView.AutoGenerateColumns = false;
        AbilitiesDataGridView.DataSource = g.Abilities;
        VersionGroupDataGridView.AutoGenerateColumns = false;
        VersionGroupDataGridView.DataSource = g.VersionGroups;
        PokemonSpeciesDataGridView.AutoGenerateColumns = false;
        PokemonSpeciesDataGridView.DataSource = g.PokemonSpecies;
        TypesDataGridView.AutoGenerateColumns = false;
        TypesDataGridView.DataSource = g.Types;
    }
    #endregion
}
