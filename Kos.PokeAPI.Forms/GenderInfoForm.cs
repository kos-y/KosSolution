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
using Kos.PokeAPI.Games.Generations;
using Kos.PokeAPI.Pokemon.Genders;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 性別
/// </summary>
public partial class GenderInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url"></param>
    public GenderInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region ポケモン種族 セルクリック
    /// <summary>
    /// ポケモン種族 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokemonSpeciesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (PokemonSpeciesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (PokemonSpeciesDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonSpeciesGender pokemon) {
            return;
        }

        using PokemonSpeciesGenderInfoForm form = new(pokemon);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ポケモン種族 セルダブルクリック
    /// <summary>
    /// ポケモン種族 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokemonSpeciesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (PokemonSpeciesDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonSpeciesGender pokemon) {
            return;
        }

        using PokemonSpeciesGenderInfoForm form = new(pokemon);
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
        Gender? gender = Gender.GetResource(url);
        if (gender is null) {
            return;
        }

        Tag = gender;
        FormsHelper.SetData(gender.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(gender.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(gender.PokemonSpeciesDetails, PokemonSpeciesCaptionLabel, PokemonSpeciesDataGridView);
        FormsHelper.SetData(gender.RequiredForEvolution, RequiredForEvolutionCaptionLabel, RequiredForEvolutionDataGridView);
    }
    #endregion
}
