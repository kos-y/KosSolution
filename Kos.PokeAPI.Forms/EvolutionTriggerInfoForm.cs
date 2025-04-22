using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Evolution.EvolutionChains;
using Kos.PokeAPI.Evolution.EvolutionTriggers;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// Evolution Trigger
/// </summary>
public partial class EvolutionTriggerInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url"></param>
    public EvolutionTriggerInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region names DataGrdiView CellClick
    /// <summary>
    /// names DataGrdiView CellClick
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

    #region names DataGrdiView CellDoubleClick
    /// <summary>
    /// names DataGrdiView CellDoubleClick
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
    public void SetData(string url)
    {
        EvolutionTrigger? et = EvolutionTrigger.GetEvolutionTrigger(url);
        if (et is null) {
            return;
        }

        IdLabel.Text = $"{et.Id}";
        NameLabel.Text = et.Name ?? string.Empty;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = et.Names;
        PokemonSpeciesDataGridView.AutoGenerateColumns = false;
        PokemonSpeciesDataGridView.DataSource = et.PokemonSpecies;
    }
    #endregion
}
