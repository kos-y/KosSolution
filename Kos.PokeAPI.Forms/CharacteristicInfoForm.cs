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
using Kos.PokeAPI.Pokemon.Characteristics;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 個性
/// </summary>
public partial class CharacteristicInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public CharacteristicInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
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

    #region 言語との説明 セルダブルクリック
    /// <summary>
    /// 言語との説明 セルダブルクリック
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

    #region プロパティ クリック
    /// <summary>
    /// プロパティ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PropertyButton_Click(object sender, EventArgs e)
    {
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
    /// <param name="url"></param>
    private void SetData(string url)
    {
        Characteristic? characteristic = Characteristic.GetResource(url);
        if (characteristic is null) {
            return;
        }

        Tag = characteristic;
        FormsHelper.SetData(characteristic.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(characteristic.HighestStat, HightStatButton, HighestStatTextBox);
        FormsHelper.SetData(characteristic.GeneModulo, GeneModuloCaptionLabel, GeneModuloTextBox);
        FormsHelper.SetData(characteristic.Descriptions, DescriptionsCaptionLabel, DescriptionsDataGridView);
        if (characteristic.PossibleValues is null) {
            PossibleValuesCaptionLabel.Enabled = false;
            PossibleValuesDataGridView.Enabled = false;
        } else {
            PossibleValuesCaptionLabel.Enabled = true;
            PossibleValuesDataGridView.Enabled = true;
            foreach (int v in characteristic.PossibleValues) {
                PossibleValuesDataGridView.Rows.Add([v]);
            }
        }
    }
    #endregion
}
