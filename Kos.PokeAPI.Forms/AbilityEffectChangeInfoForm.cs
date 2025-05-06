using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Pokemon.Abilities;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// バージョンごとの効果
/// </summary>
public partial class AbilityEffectChangeInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="aec"></param>
    public AbilityEffectChangeInfoForm(AbilityEffectChange aec)
    {
        InitializeComponent();
        SetData(aec);
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

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not Effect ef) {
            return;
        }

        using EffectInfoForm form = new(ef);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 効果 セルダブルクリック
    /// <summary>
    /// 効果 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not Effect ef) {
            return;
        }

        using EffectInfoForm form = new(ef);
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
    /// <param name="aec"></param>
    public void SetData(AbilityEffectChange aec)
    {
        VersionGroupTextBox.Text = aec.VersionGroup?.Name ?? string.Empty;
        VersionGroupDetailButton.Tag = aec.VersionGroup;
        EffectEntriesDataGridView.AutoGenerateColumns = false;
        EffectEntriesDataGridView.DataSource = aec.EffectEntries;
    }
    #endregion
}
