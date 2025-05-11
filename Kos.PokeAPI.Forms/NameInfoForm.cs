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
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 名前
/// </summary>
public partial class NameInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="name">名前</param>
    public NameInfoForm(Name name)
    {
        InitializeComponent();
        SetData(name);
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

        if (api?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region プロパティ ボタン
    /// <summary>
    /// プロパティ ボタン
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
    /// <param name="name">名前</param>
    private void SetData(Name name)
    {
        Tag = name;
        FormsHelper.SetData(name.Text, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(name.Language, LanguageButton, LanguageTextBox);
    }
    #endregion
}
