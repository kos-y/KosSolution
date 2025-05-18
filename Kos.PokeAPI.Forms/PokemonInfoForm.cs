using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    /// <summary>
    /// アビリティ セルクリック
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
    }
}
