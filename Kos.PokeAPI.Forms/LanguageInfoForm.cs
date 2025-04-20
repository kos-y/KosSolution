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
    // 定数

    #region names DataGridView 列定義
    /// <summary>
    /// names DataGridView 列定義
    /// </summary>
    enum NamesColumn : int
    {
        Name = 1,
        Language,
        Detail
    }
    #endregion

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
    public LanguageInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region ロード
    /// <summary>
    /// ロード
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void LanguageInfo_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region NamesDataGridView CellClick
    /// <summary>
    /// NamesDataGridView CellClick
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void NamesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        DataGridViewCell cell = NamesDataGridView[e.ColumnIndex, e.RowIndex];
        if (cell is not DataGridViewButtonCell) {
            return;
        }

        object item = NamesDataGridView.Rows[e.RowIndex].DataBoundItem;
        if (item is not Name name) {
            return;
        }

        ShowNamesDetailInfo(name?.Language?.Url);
    }
    #endregion

    #region NamesDataGridView CellDoubleClick
    /// <summary>
    /// NamesDataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender">イベント発生オブジェクト</param>
    /// <param name="e">イベント引数</param>
    private void NamesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        object item = NamesDataGridView.Rows[e.RowIndex].DataBoundItem;
        if (item is not Name name) {
            return;
        }

        ShowNamesDetailInfo(name?.Language?.Url);
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
        IdLabel.Text = $"{lang.Id}";
        NameLabel.Text = $"{lang.Name}";
        OfficialLabel.Text = $"{lang.Official}";
        Iso639Label.Text = lang.Iso639;
        Iso3166Label.Text = lang.Iso3166;
        NamesDataGridView.DataSource = lang.Names;
    }
    #endregion

    #region names の情報画面表示
    /// <summary>
    /// names の情報画面表示
    /// </summary>
    /// <param name="url">URL</param>
    private void ShowNamesDetailInfo(string? url)
    {
        if (url is null) {
            return;
        }

        using LanguageInfoForm form = new(url);

        _ = form.ShowDialog(this);
    }
    #endregion
}
