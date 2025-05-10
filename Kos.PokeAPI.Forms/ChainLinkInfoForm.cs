using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.Core.Forms;
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
    public ChainLinkInfoForm(ChainLink link)
    {
        InitializeComponent();
        SetData(link);
    }
    #endregion

    #region 進化詳細 セルクリック
    /// <summary>
    /// 進化詳細 セルクリック
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

    #region 進化詳細 セルダブルクリック
    /// <summary>
    /// 進化詳細 セルダブルクリック
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

    #region 進化先 セルクリック
    /// <summary>
    /// 進化先 セルクリック
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

    #region 進化先 セルダブルクリック
    /// <summary>
    /// 進化先 セルダブルクリック
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

    #region プロパティ クリック
    /// <summary>
    /// プロパティ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PropertyButton_Click(object sender, EventArgs e)
    {
        if (Tag is null) {
            return;
        }

        using PropertyGridForm form = new(Tag);
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
    private void SetData(ChainLink link)
    {
        Tag = link;
        FormsHelper.SetData(link.IsBaby, IsBabyCaptionLabel, IsBabyTextBox);
        FormsHelper.SetData(link.Species?.Name, SpeciesButton, SpeciesTextBox);
        FormsHelper.SetData(
            link.EvolutionDetails,
            EvolutionDetailsCaptionLabel,
            EvolutionDetailsDataGridView);
        FormsHelper.SetData(link.EvolvesTo, EvolvesToCaptionLabel, EvolvesToDataGridView);
    }
    #endregion
}
