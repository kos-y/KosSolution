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
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Pokemon.Abilities;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 特性
/// </summary>
public partial class AbilityInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public AbilityInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region 世代 クリック
    /// <summary>
    /// 世代 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GenerationButton_Click(object sender, EventArgs e)
    {
        if (GenerationButton.Tag is null) {
            return;
        }

        if (GenerationButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using GenerationInfoForm form = new(api.Url);
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

    #region ポケモン セルクリック
    /// <summary>
    /// ポケモン セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AbilityPokemonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (AbilityPokemonDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (AbilityPokemonDataGridView.Rows[e.RowIndex].DataBoundItem is not AbilityPokemon pokemon) {
            return;
        }

        using AbilityPokemonInfoForm form = new(pokemon);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ポケモン セルダブルクリック
    /// <summary>
    /// ポケモン セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AbilityPokemonDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (AbilityPokemonDataGridView.Rows[e.RowIndex].DataBoundItem is not AbilityPokemon pokemon) {
            return;
        }

        using AbilityPokemonInfoForm form = new(pokemon);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region フレーバーテキスト セルクリック
    /// <summary>
    /// フレーバーテキスト セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FlavorTextEntriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not AbilityFlavorText text) {
            return;
        }

        using AbilityFlavorTextInfoForm form = new(text);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region フレーバーテキスト セルダブルクリック
    /// <summary>
    /// フレーバーテキスト セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FlavorTextEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not AbilityFlavorText text) {
            return;
        }

        using AbilityFlavorTextInfoForm form = new(text);
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
    private void EffectEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

    #region 効果変更歴 セルクリック
    /// <summary>
    /// 効果変更歴 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectChangesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EffectChangesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (EffectChangesDataGridView.Rows[e.RowIndex].DataBoundItem is not AbilityEffectChange ec) {
            return;
        }

        AbilityEffectChangeInfoForm form = new(ec);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 効果変更歴 セルダブルクリック
    /// <summary>
    /// 効果変更歴 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectChangesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EffectChangesDataGridView.Rows[e.RowIndex].DataBoundItem is not AbilityEffectChange ec) {
            return;
        }

        AbilityEffectChangeInfoForm form = new(ec);
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
        Ability? ability = Ability.GetResource(url);
        if (ability is null) {
            return;
        }

        Tag = ability;
        FormsHelper.SetData(ability.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(ability.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(ability.IsMainSeries, IsMainSeriesCaptionLabel, IIsMainSeriesTextBox);
        FormsHelper.SetData(ability.Generation, GenerationButton, GenerationTextBox);
        FormsHelper.SetData(ability.Names, NamesCaptionLabel, NamesDataGridView);
        FormsHelper.SetData(ability.Pokemon, AbilityPokemonCaptionLabel, AbilityPokemonDataGridView);
        FormsHelper.SetData(ability.FlavorTextEntries, FlavorTextEntriesDataGridView);
        FormsHelper.SetData(ability.EffectEntries, EffectEntriesDataGridView);
        FormsHelper.SetData(ability.EffectChanges, EffectChangesDataGridView);
    }
    #endregion
}
