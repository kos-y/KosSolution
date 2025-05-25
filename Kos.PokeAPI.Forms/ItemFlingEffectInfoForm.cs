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
using Kos.PokeAPI.Encounters.EncounterConditionValues;
using Kos.PokeAPI.Forms.Utility.CommonModels;
using Kos.PokeAPI.Items.ItemFlingEffects;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 「なげつける」の効果
/// </summary>
public partial class ItemFlingEffectInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public ItemFlingEffectInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region 効果 セルクリック
    /// <summary>
    /// 効果 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectEntriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not Effect effect) {
            return;
        }

        using EffectInfoForm form = new(effect);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 効果 セルダブルクリック
    /// <summary>
    /// 効果 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EffectEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not Effect effect) {
            return;
        }

        using EffectInfoForm form = new(effect);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region アイテム セルクリック
    /// <summary>
    /// アイテム セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (ItemDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (ItemDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm forn = new(api.Url);
        _ = forn.ShowDialog(this);
    }
    #endregion

    #region アイテム セルダブルクリック
    /// <summary>
    /// アイテム セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (ItemDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm forn = new(api.Url);
        _ = forn.ShowDialog(this);
    }
    #endregion

    #region プロパティ ボタン
    /// <summary>
    /// プロパティ ボタン
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

    #region データを画面に設定
    /// <summary>
    /// データを画面に設定
    /// </summary>
    /// <param name="url">URL</param>
    private void SetData(string url)
    {
        ItemFlingEffect? flingEffect = ItemFlingEffect.GetResource(url);
        if (flingEffect is null) {
            return;
        }

        Tag = flingEffect;
        FormsHelper.SetData(flingEffect.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(flingEffect.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(flingEffect.EffectEntries, EffectCaptionLabel, EffectEntriesDataGridView);
        FormsHelper.SetData(flingEffect.Items, ItemCaptionLabel, ItemDataGridView);
    }
    #endregion
}
