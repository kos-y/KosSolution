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
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 言語情報 フォーム
/// </summary>
public partial class LanguageInfoForm : Form
{
    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public LanguageInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region 言語ごとの名前 セルクリック
    /// <summary>
    /// 言語ごとの名前 セルクリック
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
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

        using NameInfoForm form = new NameInfoForm(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの名前 セルダブルクリック
    /// <summary>
    /// 言語ごとの名前 セルダブルクリック
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void NamesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        using NameInfoForm form = new NameInfoForm(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region Close クリック
    /// <summary>
    /// Close クリック
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
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
        Language? lang = Language.GetLanguage(url);
        if (lang is null) {
            return;
        }

        Tag = lang;
        IdTextBox.Text = $"{lang.Id}";
        NameTextBox.Text = lang.Name;
        OfficialTextBox.Text = $"{lang.Official}";
        Iso639TextBox.Text = $"{lang.Iso639}";
        Iso3166TextBox.Text = $"{lang.Iso3166}";
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = lang.Names;
    }
    #endregion
}
