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
using Kos.PokeAPI.Forms.Utility.Languages;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 技のフレーバーテキスト
/// </summary>
public partial class MoveFlavorTextInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="mft"></param>
    public MoveFlavorTextInfoForm(MoveFlavorText mft)
    {
        InitializeComponent();
        SetData(mft);
    }
    #endregion

    #region バージョングループ クリック
    /// <summary>
    /// バージョングループ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupButton_Click(object sender, EventArgs e)
    {
        if (VersionGroupButton.Tag is null) {
            return;
        }

        if (VersionGroupButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語 クリック
    /// <summary>
    /// 言語 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LanguageButton_Click(object sender, EventArgs e)
    {
        if (LanguageButton.Tag is null) {
            return;
        }

        if (LanguageButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region プロパティ クリック
    /// <summary>
    /// プロパティ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PropertyGrid_Click(object sender, EventArgs e)
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
    /// <param name="text"></param>
    private void SetData(MoveFlavorText text)
    {
        Tag = text;
        FormsHelper.SetData(text.VersionGroup, VersionGroupButton, VersionGroupTextBox);
        FormsHelper.SetData(text.Language, LanguageButton, LanguageTextBox);
        FormsHelper.SetData(text.FlavorText, FlavorTextCaptionLabel, FlavorTextTextBox);
    }
    #endregion
}
