using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 効果
/// </summary>
public partial class VerboseEffectInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ve">効果</param>
    public VerboseEffectInfoForm(VerboseEffect ve)
    {
        InitializeComponent();
        SetData(ve);
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

        if (api?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 閉じる
    /// <summary>
    /// 閉じる
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
    /// <param name="ve">効果</param>
    private void SetData(VerboseEffect ve)
    {
        ShortEffectTextBox.Text = ve.ShortEffect ?? string.Empty;
        EffectTextBox.Text
            = (ve.Effect ?? string.Empty).Replace("\r\n", "\n")
                                         .Replace("\n", $"{Environment.NewLine}");
        LanguageTextBox.Text = ve.Language?.Name ?? string.Empty;
        LanguageDetailButton.Tag = ve.Language;
    }
    #endregion
}
