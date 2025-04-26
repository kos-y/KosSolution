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

    #region 言語 詳細 クリック
    /// <summary>
    /// 言語 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LanguageDetailButton_Click(object sender, EventArgs e)
    {
        if (LanguageDetailButton.Tag is null) {
            return;
        }

        if (LanguageDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョン 詳細 クリック
    /// <summary>
    /// バージョン 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionDetailButton_Click(object sender, EventArgs e)
    {
        if (VersionDetailButton.Tag is null) {
            return;
        }

        if (VersionDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region データを画面に表示
    /// <summary>
    /// データを画面に表示
    /// </summary>
    /// <param name="ft"></param>
    private void SetData(FlavorText ft)
    {
        FlavorTextTextBox.Text
            = (ft.Text ?? string.Empty).Replace("\r\n", "\n")
                                       .Replace("\n", Environment.NewLine);
        LanguageTextBox.Text = ft.Language?.Name ?? string.Empty;
        LanguageDetailButton.Tag = ft.Language;
        VersionTextBox.Text = ft.Version?.Name ?? string.Empty;
        VersionDetailButton.Tag = ft.Version;
    }
    #endregion
}
