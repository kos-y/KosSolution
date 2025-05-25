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
using Kos.PokeAPI.Pokemon.Pokemon;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモン
/// </summary>
public partial class PokemonInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PokemonInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region ゲーム上のインデックス セルクリック
    /// <summary>
    /// ゲーム上のインデックス セルクリック
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

        if (GameIndiceDataGridView.Rows[e.RowIndex].DataBoundItem is not VersionGameIndex index) {
            return;
        }

        using VersionGameIndexInfoForm form = new(index);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ゲーム上のインデックス セルダブルクリック
    /// <summary>
    /// ゲーム上のインデックス セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GameIndiceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (GameIndiceDataGridView.Rows[e.RowIndex].DataBoundItem is not VersionGameIndex index) {
            return;
        }

        using VersionGameIndexInfoForm form = new(index);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region タイプ セルクリック
    /// <summary>
    /// タイプ セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TypesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (TypesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (TypesDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonType type) {
            return;
        }

        using PokemonTypeInfoForm form = new(type);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region タイプ セルダブルクリック
    /// <summary>
    /// タイプ セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TypesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (TypesDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonType type) {
            return;
        }

        using PokemonTypeInfoForm form = new(type);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 特性 セルクリック
    /// <summary>
    /// 特性 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AbilitiesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (AbilitiesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (AbilitiesDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonAbility ability) {
            return;
        }

        using PokemonAbilityInfoForm form = new(ability);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 特性 セルダブルクリック
    /// <summary>
    /// 特性 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AbilitiesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (AbilitiesDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonAbility ability) {
            return;
        }

        using PokemonAbilityInfoForm form = new(ability);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ステータス セルクリック
    /// <summary>
    /// ステータス セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StatsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (StatsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (StatsDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonStat stat) {
            return;
        }

        using PokemonStatInfoForm form = new(stat);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ステータス セルダブルクリック
    /// <summary>
    /// ステータス セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StatsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (StatsDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonStat stat) {
            return;
        }

        using PokemonStatInfoForm form = new(stat);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技 セルクリック
    /// <summary>
    /// 技 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MovesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (MovesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (MovesDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonMove move) {
            return;
        }

        using PokemonMoveInfoForm form = new(move);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技 セルダブルクリック
    /// <summary>
    /// 技 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MovesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (MovesDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonMove move) {
            return;
        }

        using PokemonMoveInfoForm form = new(move);
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
        Pokemon.Pokemon.Pokemon? pokemon = Pokemon.Pokemon.Pokemon.GetResource(url);
        if (pokemon is null) {
            return;
        }

        Tag = pokemon;
        FormsHelper.SetData(pokemon.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(pokemon.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(pokemon.BaseExperience, BaseExperienceCaptionLabel, BaseExperienceTextBox);
        FormsHelper.SetData(pokemon.Height, HeightCaptionLabel, HeightTextBox);
        FormsHelper.SetData(pokemon.Weight, WeightCaptionLabel, WeightTextBox);
        FormsHelper.SetData(pokemon.Order, OrderCaptionLabel, OrderTextBox);
        FormsHelper.SetData(pokemon.Species, SpeciesButton, SpeciesTextBox);
        FormsHelper.SetData(pokemon.IsDefault, IsDefaultCaptionLabel, IsDefaultTextBox);
        FormsHelper.SetData(pokemon.GameIndices, GameIndiceCaptionLabel, GameIndiceDataGridView);
        FormsHelper.SetData(pokemon.Types, TypesCaptionLabel, TypesDataGridView);
        FormsHelper.SetData(pokemon.Abilities, AbilitiesCaptionLabel, AbilitiesDataGridView);
        FormsHelper.SetData(pokemon.Stats, StatsCaptionLabel, StatsDataGridView);
        FormsHelper.SetData(pokemon.Forms, FormsCaptionLabel, FormsDataGridView);
        FormsHelper.SetData(pokemon.Moves, MovesCaptionLabel, MovesDataGridView);
        FormsHelper.SetData(pokemon.HeldItems, HeldItemsCaptionLabel, HeldItemsDataGridView);
        FormsHelper.SetData(pokemon.Sprites?.FrontDefault, SpriteFrontDefaultPictureBox);
        FormsHelper.SetData(pokemon.Sprites?.FrontShiny, SpriteFrontShinyPictureBox);
        FormsHelper.SetData(pokemon.Sprites?.FrontFemale, SpriteFrontFemalePictureBox);
        FormsHelper.SetData(pokemon.Sprites?.FrontShinyFemale, SpriteFrontShinyFemalePictureBox);
        FormsHelper.SetData(pokemon.Sprites?.BackDefault, SpriteBackDefaultPictureBox);
        FormsHelper.SetData(pokemon.Sprites?.BackShiny, SpriteBackShinyPictureBox);
        FormsHelper.SetData(pokemon.Sprites?.BackFemale, SpriteBackFemalePictureBox);
        FormsHelper.SetData(pokemon.Sprites?.BackShinyFemale, SpriteBackShinyFemalePictureBox);
        FormsHelper.SetData(pokemon.LocationAreaEncounters, LocationAreaEncountersButton);
    }
    #endregion
}
