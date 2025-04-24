using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Games.Pokedexes;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// バージョン
/// </summary>
public partial class VersionInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public VersionInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
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

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        if (name?.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(name.Language.Url);
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

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        if (name?.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(name.Language.Url);
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
    void SetData(string url)
    {
        Games.Version.Version? v = Games.Version.Version.GetVersion(url);
        if (v is null) {
            return;
        }

        IdLabel.Text = $"{v.Id}";
        NameLabel.Text = v.Name ?? string.Empty;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = v.Names;
        VersionGroupLabel.Text = v.VersionGroup?.Name ?? string.Empty;
        VersionGroupInfoButton.Tag = v.VersionGroup;
    }
    #endregion
}
