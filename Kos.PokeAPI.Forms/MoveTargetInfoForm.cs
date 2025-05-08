using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Moves.MoveTargets;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 技の対象
/// </summary>
public partial class MoveTargetInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MoveTargetInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
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

        using NameInfoForm form = new NameInfoForm(name);
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

        using NameInfoForm form = new NameInfoForm(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技 セルクリック
    /// <summary>
    /// 技 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (MoveDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (MoveDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技 セルダブルクリック
    /// <summary>
    /// 技 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (MoveDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの説明 セルクリック
    /// <summary>
    /// 言語ごとの説明 セルクリック
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

        if (DescriptionsDataGridView.Rows[e.RowIndex].DataBoundItem is not Description d) {
            return;
        }

        using DescriptionInfoForm form = new(d);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの説明 セルダブルクリック
    /// <summary>
    /// 言語ごとの説明 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DescriptionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (DescriptionsDataGridView.Rows[e.RowIndex].DataBoundItem is not Description d) {
            return;
        }

        using DescriptionInfoForm form = new(d);
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

    #region データの設定
    /// <summary>
    /// データの設定
    /// </summary>
    /// <param name="url"></param>
    private void SetData(string url)
    {
        MoveTarget? mt = MoveTarget.GetResource(url);
        if (mt is null) {
            return;
        }

        IdTextBox.Text = $"{mt.Id}";
        NameTextBox.Text = mt.Name;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = mt.Names;
        MoveDataGridView.AutoGenerateColumns = false;
        MoveDataGridView.DataSource = mt.Moves;
        DescriptionsDataGridView.AutoGenerateColumns = false;
        DescriptionsDataGridView.DataSource = mt.Descriptions;
    }
    #endregion
}
