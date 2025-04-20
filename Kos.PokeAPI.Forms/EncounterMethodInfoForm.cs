using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Contests.ContestEffects;
using Kos.PokeAPI.Encounters.EncounterMethods;
using Kos.PokeAPI.Utility.CommonModels;
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Forms;
public partial class EncounterMethodInfoForm : Form
{
    // フィールド

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url;
    #endregion

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public EncounterMethodInfoForm(string url)
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
    private void EncounterMethodInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region Names DataGridView CellClick
    /// <summary>
    /// Names DataGridView CellClick
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

    #region Names DataGridView CellDoubleClick
    /// <summary>
    /// Names DataGridView CellDoubleClick
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
        EncounterMethod? em = EncounterMethod.GetEncountMethod(url);
        if (em is null) {
            return;
        }

        Tag = em;
        IdLabel.Text = $"{em.Id}";
        NameLabel.Text = em.Name;
        OrderLabel.Text = $"{em.Order}";
        NamesDataGridView.DataSource = em.Names;
    }
    #endregion
}
