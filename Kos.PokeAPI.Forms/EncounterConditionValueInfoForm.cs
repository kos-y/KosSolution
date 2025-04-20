using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Encounters.EncounterConditionValues;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 遭遇条件値
/// </summary>
public partial class EncounterConditionValueInfoForm : Form
{
    // フィールド

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public EncounterConditionValueInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region Load
    /// <summary>
    /// Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EncounterConditionValueInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region Condition Info Click
    /// <summary>
    /// Condition Info Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ConditionInfoButton_Click(object sender, EventArgs e)
    {
        if (ConditionInfoButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EncounterConditionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region names DataGridView CellClick
    /// <summary>
    /// names DataGridView CellClick
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

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name item) {
            return;
        }

        if (item.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(item.Language.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region names DataGridView CellDoubleClick
    /// <summary>
    /// names DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NamesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name item) {
            return;
        }

        if (item.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(item.Language.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region Close Click
    /// <summary>
    /// Close Click
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
    /// <param name="url">URL</param>
    private void SetData(string url)
    {
        EncounterConditionValue? ecv = EncounterConditionValue.GetEncountConditionValue(url);
        if (ecv is null) {
            return;
        }

        Tag = ecv;
        IdLabel.Text = $"{ecv.Id}";
        NameLabel.Text = ecv.Name;
        ConditionLabel.Text = ecv.Condition?.Name ?? string.Empty;
        ConditionInfoButton.Tag = ecv.Condition;
        NamesDataGridView.DataSource = ecv.Names;
    }
    #endregion
}
