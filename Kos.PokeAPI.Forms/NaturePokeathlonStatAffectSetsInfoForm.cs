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
using Kos.PokeAPI.Pokemon.PokeathlonStats;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 性格が影響を与えるポケスロンのステータスセット
/// </summary>
public partial class NaturePokeathlonStatAffectSetsInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public NaturePokeathlonStatAffectSetsInfoForm(NaturePokeathlonStatAffectSets set)
    {
        InitializeComponent();
        SetData(set);
    }
    #endregion

    #region 上昇する性格リスト セルクリック
    /// <summary>
    /// 上昇する性格リスト セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void IncreaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (IncreaseDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (IncreaseDataGridView.Rows[e.RowIndex].DataBoundItem is not NaturePokeathlonStatAffect a) {
            return;
        }

        using NaturePokeathlonStatAffectInfoForm form = new(a);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 上昇する性格リスト セルダブルクリック
    /// <summary>
    /// 上昇する性格リスト セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void IncreaseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (IncreaseDataGridView.Rows[e.RowIndex].DataBoundItem is not NaturePokeathlonStatAffect a) {
            return;
        }

        using NaturePokeathlonStatAffectInfoForm form = new(a);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 下降する性格 セルクリック
    /// <summary>
    /// 下降する性格 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DecreaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (DecreaseDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (DecreaseDataGridView.Rows[e.RowIndex].DataBoundItem is not NaturePokeathlonStatAffect a) {
            return;
        }

        using NaturePokeathlonStatAffectInfoForm form = new(a);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 下降する性格 セルダブルクリック
    /// <summary>
    /// 下降する性格 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DecreaseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (DecreaseDataGridView.Rows[e.RowIndex].DataBoundItem is not NaturePokeathlonStatAffect a) {
            return;
        }

        using NaturePokeathlonStatAffectInfoForm form = new(a);
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

    #region データの設定
    /// <summary>
    /// データの設定
    /// </summary>
    /// <param name="set"></param>
    private void SetData(NaturePokeathlonStatAffectSets set)
    {
        Tag = set;
        FormsHelper.SetData(set.Increase, IncreaseCaptionLabel, IncreaseDataGridView);
        FormsHelper.SetData(set.Decrease, DecreaseCaptionLabel, DecreaseDataGridView);
    }
    #endregion
}
