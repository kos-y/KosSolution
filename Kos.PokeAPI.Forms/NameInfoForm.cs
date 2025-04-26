using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    #region 言語 詳細 クリック
    /// <summary>
    /// 言語 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LanguageDetailButton_Click(object sender, EventArgs e)
    {
        object? tag = LanguageDetailButton.Tag;
        if (tag is null) {
            return;
        }

        if (tag is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(api.Url);
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
        NameTextBox.Text = name.Text ?? string.Empty;
        LanguageTextBox.Text = name.Language?.Name ?? string.Empty;
        LanguageDetailButton.Tag = name.Language;
    }
    #endregion
}
