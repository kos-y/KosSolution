using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public AbilityPokemonInfoForm(AbilityPokemon ap)
    {
        InitializeComponent();
        SetData(ap);
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
    /// <param name="ap"></param>
    private void SetData(AbilityPokemon ap)
    {
        PokemonTextBox.Text = ap.Pokemon?.Name ?? string.Empty;
        PokemonDetailButton.Tag = ap.Pokemon;
        SlotTextBox.Text = $"{ap.Slot}";
        IsHiddenTextBox.Text = $"{ap.IsHidden}";
    }
    #endregion
}
