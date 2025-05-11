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
    public PastMoveStatValuesInfoForm(PastMoveStatValues past)
    {
        InitializeComponent();
        SetData(past);
    }
    #endregion

    #region バージョングループ クリック
    /// <summary>
    /// バージョングループ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupButton_Click(object sender, EventArgs e)
    {
        if (VersionGroupButton.Tag is null) {
            return;
        }

        if (VersionGroupButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region タイプ クリック
    /// <summary>
    /// タイプ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TypeButton_Click(object sender, EventArgs e)
    {
        if (TypeButton.Tag is null) {
            return;
        }

        if (TypeButton.Tag is not NamedAPIResource api) {
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
    /// <param name="past"></param>
    private void SetData(PastMoveStatValues past)
    {
        Tag = past;
        FormsHelper.SetData(past.VersionGroup, VersionGroupButton, VersionGroupTextBox);
        FormsHelper.SetData(past.Type, TypeButton, TypeTextBox);
        FormsHelper.SetData(past.PP, PPCaptionLabel, PPTextBox);
        FormsHelper.SetData(past.Accuracy, AccuracyCaptionLabel, AccuracyTextBox);
        FormsHelper.SetData(past.EffectChance, EffectChanceCaptionLabel, EffectChanceTextBox);
        FormsHelper.SetData(past.Power, PowerCaptionLabel, PowerTextBox);
        FormsHelper.SetData(past.EffectEntries, EffectEntriesDataGridView);
    }
    #endregion
}
