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

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 進化チェーンリンク
/// </summary>
public partial class ChainLinkInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ChainLinkInfoForm(ChainLink cl)
    {
        InitializeComponent();
        SetData(cl);
    }
    #endregion

    #region evolution_details DataGridView CellClick
    /// <summary>
    /// evolution_details DataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EvolutionDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EvolutionDetailsDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (EvolutionDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            EvolutionDetail ed) {
            return;
        }

        using EvolutionDetailInfoForm form = new(ed);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region evolution_details DataGridView CellDoubleClick
    /// <summary>
    /// evolution_details DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EvolutionDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EvolutionDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            EvolutionDetail ed) {
            return;
        }

        using EvolutionDetailInfoForm form = new(ed);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region evolves_to DataGridView CellClick
    /// <summary>
    /// evolves_to DataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EvolvesToDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EvolvesToDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (EvolvesToDataGridView.Rows[e.RowIndex].DataBoundItem is not ChainLink cl) {
            return;
        }

        using ChainLinkInfoForm form = new(cl);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region evolves_to DataGridView CellDoubleClick
    /// <summary>
    /// evolves_to DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EvolvesToDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EvolvesToDataGridView.Rows[e.RowIndex].DataBoundItem is not ChainLink cl) {
            return;
        }

        using ChainLinkInfoForm form = new(cl);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region Close クリック
    /// <summary>
    /// Close クリック
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
    private void SetData(ChainLink cl)
    {
        IsBabyLabel.Text = $"{cl.IsBaby}";
        SpeciesLabel.Text = cl.Species?.Name ?? string.Empty;
        SpeciesInfoButton.Tag = cl.Species;
        EvolutionDetailsDataGridView.AutoGenerateColumns = false;
        EvolutionDetailsDataGridView.DataSource = cl.EvolutionDetails;
        EvolvesToDataGridView.AutoGenerateColumns = false;
        EvolvesToDataGridView.DataSource = cl.EvolvesTo;
    }
    #endregion
}
