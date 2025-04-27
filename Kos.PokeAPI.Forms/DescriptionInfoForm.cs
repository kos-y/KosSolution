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
/// 説明
/// </summary>
public partial class DescriptionInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public DescriptionInfoForm(Description desc)
    {
        InitializeComponent();
        SetData(desc);
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

    #region 画面にデータの設定
    /// <summary>
    /// 画面にデータの設定
    /// </summary>
    /// <param name="desc"></param>
    private void SetData(Description desc)
    {
        DescriptionTextBox.Text = desc.Text;
        LanguageTextBox.Text = desc.Language?.Name ?? string.Empty;
        LanguageDetailButton.Tag = desc.Language;
    }
    #endregion
}
