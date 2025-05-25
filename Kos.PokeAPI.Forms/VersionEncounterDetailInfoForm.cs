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
using Kos.PokeAPI.Forms.Utility.CommonModels;
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
    private void VersionButton_Click(object sender, EventArgs e)
    {
        if (VersionButton.Tag is null) {
            return;
        }

        if (VersionButton.Tag is not NamedAPIResource api) {
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

    #region データ設定
    /// <summary>
    /// データ設定
    /// </summary>
    /// <param name="ved"></param>
    private void SetData(VersionEncounterDetail ved)
    {
        Tag = ved;
        FormsHelper.SetData(ved.Version, VersionButton, VersionTextBox);
        FormsHelper.SetData(ved.MaxChance, MaxChanceCaptionLabel, MaxChanceTextBox);
        FormsHelper.SetData(ved.EncounterDetails, EncounterDetailsCaptionLabel, EncounterDetailsDataGridView);
    }
    #endregion
}
