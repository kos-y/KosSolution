using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.Core.Forms;
using Kos.PokeAPI.Items.ItemAttributes;
using Kos.PokeAPI.Items.ItemCategories;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// アイテム特性
/// </summary>
public partial class ItemAttributeInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public ItemAttributeInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
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

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
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

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの説明 セルクリック
    /// <summary>
    /// 言語ごとの説明 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DescriptionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (DescriptionsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (DescriptionsDataGridView.Rows[e.RowIndex].DataBoundItem is not Description desc) {
            return;
        }

        using DescriptionInfoForm form = new(desc);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの説明 セルダブルクリック
    /// <summary>
    /// 言語ごとの説明 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        DescriptionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (DescriptionsDataGridView.Rows[e.RowIndex].DataBoundItem is not Description desc) {
            return;
        }

        using DescriptionInfoForm form = new(desc);
        _ = form.ShowDialog(this);
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

    #region 画面にデータの設定
    /// <summary>
    /// 画面にデータの設定
    /// </summary>
    /// <param name="url"></param>
    private void SetData(string url)
    {
        ItemAttribute? attr = ItemAttribute.GetItemAttribute(url);
        if (attr is null) {
            return;
        }

        Tag = attr;
        FormsHelper.SetData(attr.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(attr.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(attr.Names, NamesCaptionLabel, NamesDataGridView);
        FormsHelper.SetData(attr.Descriptions, DescriptionsCaptionLabel, DescriptionsDataGridView);
        FormsHelper.SetData(attr.Items, ItemCaptionLabel, ItemDataGridView);
    }
    #endregion
}
