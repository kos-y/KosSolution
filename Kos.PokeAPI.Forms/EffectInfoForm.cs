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
/// 効果
/// </summary>
public partial class EffectInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public EffectInfoForm(Effect e)
    {
        InitializeComponent();
        SetData(e);
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

    #region 画面にデータを設定
    /// <summary>
    /// 画面にデータを設定
    /// </summary>
    /// <param name="e"></param>
    private void SetData(Effect e)
    {
        EffectTextBox.Text = e.Text ?? string.Empty;
        LanguageTextBox.Text = e.Language?.Name ?? string.Empty;
        LanguageDetailButton.Tag = e.Language;
    }
    #endregion
}
