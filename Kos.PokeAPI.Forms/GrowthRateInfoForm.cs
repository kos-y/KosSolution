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
using Kos.PokeAPI.Pokemon.GrowthRates;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// レベルアップに必要な経験値の増加量
/// </summary>
public partial class GrowthRateInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url"></param>
    public GrowthRateInfoForm(string url)
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

    private void PokemonSpeciesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {

    }

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
        GrowthRate? growth = GrowthRate.GetResource(url);
        if (growth is null) {
            return;
        }

        Tag = growth;
        FormsHelper.SetData(growth.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(growth.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(growth.Formula, FormulaCaptionLabel, FormulaTextBox);
        FormsHelper.SetData(growth.Descriptions, DescriptionsCaptionLabel, DescriptionsDataGridView);
        FormsHelper.SetData(growth.Levels, LevelsCaptionLabel, LevelsDataGridView);
        FormsHelper.SetData(growth.PokemonSpecies, PokemonSpeciesCaptionLabel, PokemonSpeciesDataGridView);
    }
    #endregion
}
