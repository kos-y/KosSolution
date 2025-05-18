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
using Kos.PokeAPI.Pokemon.Pokemon;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモンの特性
/// </summary>
public partial class PokemonAbilityInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PokemonAbilityInfoForm(PokemonAbility ability)
    {
        InitializeComponent();
        SetData(ability);
    }
    #endregion

    #region 特性ボタン クリック
    /// <summary>
    /// 特性ボタン クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AbilityButton_Click(object sender, EventArgs e)
    {
        if (AbilityButton.Tag is null) {
            return;
        }

        if (AbilityButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using AbilityInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region プロパティ 区7リック
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

        PropertyGridForm form = new(Tag);
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
    /// <param name="ability"></param>
    private void SetData(PokemonAbility ability)
    {
        Tag = ability;
        FormsHelper.SetData(ability.Slot, SlotCaptionLabel, SlotTextBox);
        FormsHelper.SetData(ability.Ability, AbilityButton, AbilityTextBox);
        FormsHelper.SetData(ability.IsHidden, IsHiddenCaptionLabel, IsHiddenTextBox);
    }
    #endregion
}
