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
using Kos.PokeAPI.Pokemon.Natures;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 性格
/// </summary>
public partial class NatureInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url"></param>
    public NatureInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region きのみ 好きな味 クリック
    /// <summary>
    /// きのみ 好きな味 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LikesFlavorButton_Click(object sender, EventArgs e)
    {
        if (LikesFlavorButton.Tag is null) {
            return;
        }

        if (LikesFlavorButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using BerryFlavorInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region きのみ 嫌いな味 クリック
    /// <summary>
    /// きのみ 嫌いな味 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HatesFlavorButton_Click(object sender, EventArgs e)
    {
        if (HatesFlavorButton.Tag is null) {
            return;
        }

        if (HatesFlavorButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using BerryFlavorInfoForm form = new(api.Url);
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

        if (NamesDataGridView[e.RowIndex, e.ColumnIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        using NameInfoForm form = new(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語との名前 セルダブルクリック
    /// <summary>
    /// 言語との名前 セルダブルクリック
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

    #region 戦闘スタイル セルクリック
    /// <summary>
    /// 戦闘スタイル セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveBattleStylePreferencesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (MoveBattleStylePreferencesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (MoveBattleStylePreferencesDataGridView.Rows[e.RowIndex].DataBoundItem is not MoveBattleStylePreference style) {
            return;
        }

        using MoveBattleStylePreferenceInfoForm form = new(style);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 戦闘スタイル セルダブルクリック
    /// <summary>
    /// 戦闘スタイル セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveBattleStylePreferencesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (MoveBattleStylePreferencesDataGridView.Rows[e.RowIndex].DataBoundItem is not MoveBattleStylePreference style) {
            return;
        }

        using MoveBattleStylePreferenceInfoForm form = new(style);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 影響を与えるポケスロンのステータス セルクリック
    /// <summary>
    /// 影響を与えるポケスロンのステータス セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokeathlonStatChangesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (PokeathlonStatChangesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (PokeathlonStatChangesDataGridView.Rows[e.RowIndex].DataBoundItem is not NatureStatChange change) {
            return;
        }

        using NatureStatChangeInfoForm form = new(change);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 影響を与えるポケスロンのステータス セルダブルクリック
    /// <summary>
    /// 影響を与えるポケスロンのステータス セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokeathlonStatChangesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (PokeathlonStatChangesDataGridView.Rows[e.RowIndex].DataBoundItem is not NatureStatChange change) {
            return;
        }

        using NatureStatChangeInfoForm form = new(change);
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
    /// <param name="url"></param>
    private void SetData(string url)
    {
        Nature? nature = Nature.GetResource(url);
        if (nature is null) {
            return;
        }

        Tag = nature;
        FormsHelper.SetData(nature.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(nature.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(nature.IncreasedStat, IncreasedStatButton, IncreasedStatTextBox);
        FormsHelper.SetData(nature.DecreasedStat, DecreasedStatButton, DecreasedStatTextBox);
        FormsHelper.SetData(nature.LikesFlavor, LikesFlavorButton, LikesFlavorTextBox);
        FormsHelper.SetData(nature.HatesFlavor, HatesFlavorButton, HatesFlavorTextBox);
        FormsHelper.SetData(nature.Names, NamesCaptionLabel, NamesDataGridView);
        FormsHelper.SetData(
            nature.MoveBattleStylePreferences,
            MoveBattleStylePreferenceCaptionLabel,
            MoveBattleStylePreferencesDataGridView);
        FormsHelper.SetData(
            nature.PokeathlonStatChanges,
            PokeathlonStatChangesCaptionLabel,
            PokeathlonStatChangesDataGridView);
    }
    #endregion
}
