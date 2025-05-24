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
using Kos.Core.Forms;
using Kos.PokeAPI.Forms.Utility.Languages;
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
    /// <param name="ve">効果</param>
    private void SetData(VerboseEffect ve)
    {
        Tag = ve;
        FormsHelper.SetData(ve.Language, LanguageButton, LanguageTextBox);
        FormsHelper.SetData(ve.ShortEffect, ShortEffectCaptionLabel, ShortEffectTextBox);
        FormsHelper.SetData(ve.Effect, EffectCaptionLabel, EffectTextBox);
    }
    #endregion
}
