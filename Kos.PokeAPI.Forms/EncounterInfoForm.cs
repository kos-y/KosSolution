using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 遭遇
/// </summary>
public partial class EncounterInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="e">遭遇</param>
    public EncounterInfoForm(Encounter e)
    {
        InitializeComponent();
        SetData(e);
    }
    #endregion

    #region 遭遇方法 詳細 クリック
    /// <summary>
    /// 遭遇方法 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MethodDetailButton_Click(object sender, EventArgs e)
    {
        if (MethodDetailButton.Tag is null) {
            return;
        }

        if (MethodDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EncounterMethodInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇条件値 セルクリック
    /// <summary>
    /// 遭遇条件値 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ConditionValuesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (ConditionValuesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (ConditionValuesDataGridView.Rows[e.RowIndex].DataBoundItem is not
            NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EncounterConditionValueInfoForm form = new EncounterConditionValueInfoForm(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇条件値 セルダブルクリック
    /// <summary>
    /// 遭遇条件値 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        ConditionValuesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (ConditionValuesDataGridView.Rows[e.RowIndex].DataBoundItem is not
            NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EncounterConditionValueInfoForm form = new EncounterConditionValueInfoForm(api.Url);
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
    /// <param name="e">遭遇</param>
    private void SetData(Encounter e)
    {
        MethodTextBox.Text = e.Method?.Name ?? string.Empty;
        MethodDetailButton.Tag = e.Method;
        ChanceTextBox.Text = $"{e.Chance}";
        MinLevelTextBox.Text = $"{e.MinLevel}";
        MaxLevelTextBox.Text = $"{e.MaxLevel}";
        ConditionValuesDataGridView.DataSource = e.ConditionValues;
    }
    #endregion
}
