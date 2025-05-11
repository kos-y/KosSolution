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
using Kos.PokeAPI.Pokemon.Abilities;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモンの特性
/// </summary>
public partial class AbilityPokemonInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public AbilityPokemonInfoForm(AbilityPokemon pokemon)
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
    private void SetData(AbilityPokemon pokemon)
    {
        Tag = pokemon;
        FormsHelper.SetData(pokemon.Pokemon, PokemonButton, PokemonTextBox);
        FormsHelper.SetData(pokemon.Slot, SlotCaptionLabel, SlotTextBox);
        FormsHelper.SetData(pokemon.IsHidden, IsHiddenCaptionLabel, IsHiddenTextBox);
    }
    #endregion
}
