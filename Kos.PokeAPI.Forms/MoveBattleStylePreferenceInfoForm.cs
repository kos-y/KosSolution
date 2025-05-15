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
using Kos.PokeAPI.Pokemon.Natures;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 性格と戦闘スタイルの関係性
/// </summary>
public partial class MoveBattleStylePreferenceInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MoveBattleStylePreferenceInfoForm(MoveBattleStylePreference style)
    {
        InitializeComponent();
        SetData(style);
    }
    #endregion

    #region 戦闘スタイル クリック
    /// <summary>
    /// 戦闘スタイル クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveBattleStyleButton_Click(object sender, EventArgs e)
    {
        if (MoveBattleStyleButton.Tag is null) {
            return;
        }

        if (MoveBattleStyleButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveBattleStyleInfoForm form = new(api.Url);
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
    /// <param name="style"></param>
    private void SetData(MoveBattleStylePreference style)
    {
        Tag = style;
        FormsHelper.SetData(style.MoveBattleStyle, MoveBattleStyleButton, MoveBattleStyleTextBox);
        FormsHelper.SetData(style.HighHPPreference, HighHPPreferenceCaptionLabel, HighHPPreferenceTextBox);
        FormsHelper.SetData(style.LowHPPreference, LowHPPreferenceCaptionLabel, LowHPPreferenceTextBox);
    }
    #endregion
}
