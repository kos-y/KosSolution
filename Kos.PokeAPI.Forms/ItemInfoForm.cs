using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.Core;
using Kos.Core.Forms;
using Kos.PokeAPI.Forms.Utility.CommonModels;
using Kos.PokeAPI.Items.Item;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// アイテム
/// </summary>
public partial class ItemInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public ItemInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region カテゴリ クリック
    /// <summary>
    /// カテゴリ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CategoryButton_Click(object sender, EventArgs e)
    {
        if (CategoryButton.Tag is null) {
            return;
        }

        if (CategoryButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemCategoryInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 「なげつける」の効果 クリック
    /// <summary>
    /// 「なげつける」の効果 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FlingEffectButton_Click(object sender, EventArgs e)
    {
        if (FlingEffectButton.Tag is null) {
            return;
        }

        if (FlingEffectButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemFlingEffectInfoForm form = new(api.Url);
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

    #region ゲーム内インデックス セルクリック
    /// <summary>
    /// ゲーム内インデックス セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GameIndiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (GameIndiceDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (GameIndiceDataGridView.Rows[e.RowIndex].DataBoundItem is not GenerationGameIndex ggi) {
            return;
        }

        GenerationGameIndexInfoForm form = new(ggi);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ゲーム内インデックス セルダブルクリック
    /// <summary>
    /// ゲーム内インデックス セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GameIndiceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (GameIndiceDataGridView.Rows[e.RowIndex].DataBoundItem is not GenerationGameIndex ggi) {
            return;
        }

        GenerationGameIndexInfoForm form = new(ggi);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 特性 セルクリック
    /// <summary>
    /// 特性 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AttributesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (AttributesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (AttributesDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemAttributeInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 特性 セルダブルクリック
    /// <summary>
    /// 特性 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AttributesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (AttributesDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemAttributeInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region アイテム所持ポケモン セルクリック
    /// <summary>
    /// アイテム所持ポケモン セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HeldByPokemonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (HeldByPokemonDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (HeldByPokemonDataGridView.Rows[e.RowIndex].DataBoundItem is not
            ItemHolderPokemon ihp) {
            return;
        }

        using ItemHolderPokemonInfoForm form = new(ihp);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region アイテム所持ポケモン セルダブルクリック
    /// <summary>
    /// アイテム所持ポケモン セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        HeldByPokemonDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (HeldByPokemonDataGridView.Rows[e.RowIndex].DataBoundItem is not
            ItemHolderPokemon ihp) {
            return;
        }

        using ItemHolderPokemonInfoForm form = new(ihp);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技マシン セルクリック
    /// <summary>
    /// 技マシン セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MachinesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (MachinesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (MachinesDataGridView.Rows[e.RowIndex].DataBoundItem is not MachineVersionDetail mvd) {
            return;
        }

        using MachineVersionDetailInfoForm form = new(mvd);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技マシン セルダブルクリック
    /// <summary>
    /// 技マシン セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MachinesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (MachinesDataGridView.Rows[e.RowIndex].DataBoundItem is not MachineVersionDetail mvd) {
            return;
        }

        using MachineVersionDetailInfoForm form = new(mvd);
        _ = form.ShowDialog(this);
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

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not VerboseEffect ve) {
            return;
        }

        using VerboseEffectInfoForm form = new(ve);
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

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not VerboseEffect ve) {
            return;
        }

        using VerboseEffectInfoForm form = new(ve);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region フレーバーテキスト セルクリック
    /// <summary>
    /// フレーバーテキスト セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        FlavorTextEntriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not
            VersionGroupFlavorText vgft) {
            return;
        }

        using VersionGroupFlavorTextInfoForm form = new(vgft);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region フレーバーテキスト セルダブルクリック
    /// <summary>
    /// フレーバーテキスト セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        FlavorTextEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not
            VersionGroupFlavorText vgft) {
            return;
        }

        using VersionGroupFlavorTextInfoForm form = new(vgft);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ベビーポケモンの進化トリガー クリック
    /// <summary>
    /// ベビーポケモンの進化トリガー クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BabyTriggerForInfoButton_Click(object sender, EventArgs e)
    {
        if (BabyTriggerForButton.Tag is null) {
            return;
        }

        if (BabyTriggerForButton.Tag is not APIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EvolutionChainInfoForm form = new(api.Url);
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

    #region 画面にデータの設定
    /// <summary>
    /// 画面にデータの設定
    /// </summary>
    /// <param name="url"></param>
    private void SetData(string url)
    {
        Item? item = Item.GetItem(url);
        if (item is null) {
            return;
        }

        Tag = item;
        FormsHelper.SetData(item.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(item.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(item.Cost, CostCaptionLabel, CostTextBox);
        FormsHelper.SetData(item.Category, CategoryButton, CategoryTextBox);
        FormsHelper.SetData(item.FlingEffect, FlingEffectButton, FlingEffectTextBox);
        FormsHelper.SetData(item.FlingPower, FlingPowerCaptionLabel, FlingPowerTextBox);
        FormsHelper.SetData(item.BabyTriggerFor, BabyTriggerForButton);
        FormsHelper.SetData(item.Attributes, AttributesCaptionLabel, AttributesDataGridView);
        FormsHelper.SetData(item.FlavorTextEntries, FlavorTextEntriesDataGridView);
        FormsHelper.SetData(item.Names, NameCaptionLabel, NamesDataGridView);
        FormsHelper.SetData(item.Machines, MachinesCaptionLabel, MachinesDataGridView);
        FormsHelper.SetData(item.EffectEntries, EffectEntriesDataGridView);
        FormsHelper.SetData(item.GameIndice, GameIndiceCaptionLabel, GameIndiceDataGridView);
        FormsHelper.SetData(item.HeldByPokemon, HeldByPokemonCaptionLabel, HeldByPokemonDataGridView);
        FormsHelper.SetData(item.Sprites?.Default, SpritesPictureBox);
    }
    #endregion
}
