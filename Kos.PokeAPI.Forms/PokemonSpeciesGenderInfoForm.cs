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
using Kos.PokeAPI.Pokemon.Genders;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモンごとの性別確立
/// </summary>
public partial class PokemonSpeciesGenderInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PokemonSpeciesGenderInfoForm(PokemonSpeciesGender pokemon)
    {
        InitializeComponent();
        SetData(pokemon);
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
    /// <param name="pokemon"></param>
    private void SetData(PokemonSpeciesGender pokemon)
    {
        Tag = pokemon;
        FormsHelper.SetData(pokemon.PokemonSpecies, PokemonSpeciesButton, PokemonSpeciesTextBox);
        FormsHelper.SetData(pokemon.Rate, RateCaptionLabel, RateTextBox);
    }
    #endregion
}
