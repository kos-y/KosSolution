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

    #region バージョングループ クリック
    /// <summary>
    /// バージョングループ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupButton_Click(object sender, EventArgs e)
    {
        if (VersionGroupButton.Tag is null) {
            return;
        }

        if (VersionGroupButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの名前 セルクリック
    /// <summary>
    /// 言語ごとの名前 セルクリック
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

        using NameInfoForm form = new(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの名前 セルダブルクリック
    /// <summary>
    /// 言語ごとの名前 セルダブルクリック
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

        using NameInfoForm form = new(name);
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
        if (Tag is null) {
            return;
        }

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

    #region データの表示
    /// <summary>
    /// データの表示
    /// </summary>
    /// <param name="url">URL</param>
    void SetData(string url)
    {
        Games.Version.Version? version = Games.Version.Version.GetVersion(url);
        if (version is null) {
            return;
        }

        Tag = version;
        FormsHelper.SetData(version.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(version.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(version.Names, NamesCaptionLabel, NamesDataGridView);
        FormsHelper.SetData(version.VersionGroup, VersionGroupButton, VersionGroupTextBox);
    }
    #endregion
}
