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
using Kos.PokeAPI.Utility.CommonModels;
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// フレーバーテキスト
/// </summary>
public partial class FlavorTextInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ft"></param>
    public FlavorTextInfoForm(FlavorText ft)
    {
        InitializeComponent();
        SetData(ft);
    }
    #endregion

    #region バージョン クリック
    /// <summary>
    /// バージョン クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionDetailButton_Click(object sender, EventArgs e)
    {
        if (VersionButton.Tag is null) {
            return;
        }

        if (VersionButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
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
    private void PropertyButton_Click(object sender, EventArgs e)
    {
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

    #region データを画面に表示
    /// <summary>
    /// データを画面に表示
    /// </summary>
    /// <param name="text"></param>
    private void SetData(FlavorText text)
    {
        Tag = text;
        FormsHelper.SetData(text.Text, FlavorTextCaptionLabel, FlavorTextTextBox);
        FormsHelper.SetData(text.Language, LanguageButton, LanguageTextBox);
        FormsHelper.SetData(text.Version, VersionButton, VersionTextBox);
    }
    #endregion
}
