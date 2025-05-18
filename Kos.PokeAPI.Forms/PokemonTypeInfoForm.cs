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

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモンのタイプ
/// </summary>
public partial class PokemonTypeInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="type"></param>
    public PokemonTypeInfoForm(PokemonType type)
    {
        InitializeComponent();
        SetData(type);
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
    /// <param name="type"></param>
    private void SetData(PokemonType type)
    {
        Tag = type;
        FormsHelper.SetData(type.Slot, SlotCaptionLabel, SlotTextBox);
        FormsHelper.SetData(type.Type, TypeButton, TypeTextBox);
    }
    #endregion
}
