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
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 技がもつ過去のステータス値
/// </summary>
public partial class PastMoveStatValuesInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PastMoveStatValuesInfoForm(PastMoveStatValues pmsv)
    {
        InitializeComponent();
        SetData(pmsv);
    }
    #endregion

    #region バージョングループ 詳細 クリック
    /// <summary>
    /// バージョングループ 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupDetailButton_Click(object sender, EventArgs e)
    {
        if (VersionGroupDetailButton.Tag is null) {
            return;
        }

        if (VersionGroupDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region タイプ 詳細 クリック
    /// <summary>
    /// タイプ 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TypeDetailButton_Click(object sender, EventArgs e)
    {
        if (TypeDetailButton.Tag is null) {
            return;
        }

        if (TypeDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }
    }
    #endregion

    #region 効果 セルクリック
    /// <summary>
    /// 効果 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectEntriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not VerboseEffect ve) {
            return;
        }

        using VerboseEffectInfoForm form = new(ve);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 効果 セルダブルクリック
    /// <summary>
    /// 効果 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EffectEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not VerboseEffect ve) {
            return;
        }

        using VerboseEffectInfoForm form = new(ve);
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
    /// <param name="pmsv"></param>
    private void SetData(PastMoveStatValues pmsv)
    {
        VersionGroupTextBox.Text = pmsv.VersionGroup?.Name ?? string.Empty;
        VersionGroupDetailButton.Tag = pmsv.VersionGroup;
        TypeTextBox.Text = pmsv.Type?.Name ?? string.Empty;
        TypeDetailButton.Tag = pmsv.Type;
        PPTextBox.Text = $"{pmsv.PP}";
        AccuracyTextBox.Text = $"{pmsv.Accuracy}";
        EffectChanceTextBox.Text = $"{pmsv.EffectChance}";
        PowerTextBox.Text = $"{pmsv.Power}";
        EffectEntriesDataGridView.AutoGenerateColumns = false;
        EffectEntriesDataGridView.DataSource = pmsv.EffectEntries;
    }
    #endregion
}
