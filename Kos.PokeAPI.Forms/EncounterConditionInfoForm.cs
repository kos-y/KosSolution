using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Encounters.EncounterConditions;
using Kos.PokeAPI.Encounters.EncounterMethods;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 遭遇条件
/// </summary>
public partial class EncounterConditionInfoForm : Form
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
    public EncounterConditionInfoForm(string url)
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
    private void EncounterConditionInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region NamesDataGridView CellClick
    /// <summary>
    /// NamesDataGridView CellClick
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

    #region NamesDataGridView CellDoubleClick
    /// <summary>
    /// NamesDataGridView CellClick
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
        EncounterCondition? ec = EncounterCondition.GetEncountCondition(url);
        if (ec is null) {
            return;
        }

        Tag = ec;
        IdLabel.Text = $"{ec.Id}";
        NameLabel.Text = ec.Name;
        NamesDataGridView.DataSource = ec.Names;
        ValuesDataGridView.DataSource = ec.Values;
        ValuesDataGridView.AutoGenerateColumns = false;
    }
    #endregion
}
