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
using Kos.PokeAPI.Locations.LocationAreas;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 遭遇方法とバージョンごとの遭遇率
/// </summary>
public partial class EncounterMethodRateInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public EncounterMethodRateInfoForm(EncounterMethodRate emr)
    {
        InitializeComponent();
        SetData(emr);
    }
    #endregion

    #region 遭遇方法 ボタン
    /// <summary>
    /// 遭遇方法 ボタン
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EncounterMethodButton_Click(object sender, EventArgs e)
    {
        if (EncounterMethodButton.Tag is null) {
            return;
        }

        if (EncounterMethodButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EncounterMethodInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョンごとの遭遇率 セルクリック
    /// <summary>
    /// バージョンごとの遭遇率 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (VersionDetailsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (VersionDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            EncounterVersionDetails evd) {
            return;
        }

        using EncounterVersionDetailsInfoForm form = new(evd);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョンごとの遭遇率 セルダブルクリック
    /// <summary>
    /// バージョンごとの遭遇率 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        VersionDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (VersionDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            EncounterVersionDetails evd) {
            return;
        }

        using EncounterVersionDetailsInfoForm form = new(evd);
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

    #region データの設定
    /// <summary>
    /// データの設定
    /// </summary>
    /// <param name="rate"></param>
    public void SetData(EncounterMethodRate rate)
    {
        Tag = rate;
        FormsHelper.SetData(rate.EncounterMethod, EncounterMethodButton, EncounterMethodTextBox);
        FormsHelper.SetData(rate.VersionDetails, VersionDetailsCaptionLabel, VersionDetailsDataGridView);
    }
    #endregion
}
