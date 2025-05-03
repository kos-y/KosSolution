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
/// バージョンごとの遭遇情報詳細
/// </summary>
public partial class VersionEncounterDetailInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public VersionEncounterDetailInfoForm(VersionEncounterDetail ved)
    {
        InitializeComponent();
        SetData(ved);
    }
    #endregion

    #region バージョン 詳細 クリック
    /// <summary>
    /// バージョン 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionDetailButton_Click(object sender, EventArgs e)
    {
        object? tag = VersionDetailButton.Tag;
        if (tag is null) {
            return;
        }

        if (tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        VersionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇情報詳細 セルクリック
    /// <summary>
    /// 遭遇情報詳細 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EncounterDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EncounterDetailsDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (EncounterDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not Encounter en) {
            return;
        }

        using EncounterInfoForm form = new(en);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇情報詳細 セルダブルクリック
    /// <summary>
    /// 遭遇情報詳細 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EncounterDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EncounterDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not Encounter en) {
            return;
        }

        using EncounterInfoForm form = new(en);
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

    #region データ設定
    /// <summary>
    /// データ設定
    /// </summary>
    /// <param name="ved"></param>
    private void SetData(VersionEncounterDetail ved)
    {
        VersionTextBox.Text = ved.Version?.Name ?? string.Empty;
        VersionDetailButton.Tag = ved.Version;
        MaxChanceTextBox.Text = $"{ved.MaxChance}";
        EncounterDetailsDataGridView.DataSource = ved.EncounterDetails;
    }
    #endregion
}
