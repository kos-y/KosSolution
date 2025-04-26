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
/// バージョングループのフレーバーテキスト
/// </summary>
public partial class VersionGroupFlavorTextInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public VersionGroupFlavorTextInfoForm(VersionGroupFlavorText vgft)
    {
        InitializeComponent();
        SetData(vgft);
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

    #region バージョングループ 詳細 クリック
    /// <summary>
    /// バージョングループ 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupDetailButton_Click(object sender, EventArgs e)
    {
        if (VersionGroupDetailButton.Tag is null) {
            return;
        }

        if (VersionGroupDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new VersionGroupInfoForm(api.Url);
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

    #region データを画面に設定
    /// <summary>
    /// データを画面に設定
    /// </summary>
    /// <param name="vgft">バージョングループのフレーバーテキスト</param>
    private void SetData(VersionGroupFlavorText vgft)
    {
        FlavorTextTextBox.Text = vgft.Text;
        LanguageTextBox.Text = vgft.Language?.Name ?? string.Empty;
        LanguageDetailButton.Tag = vgft.Language;
        VersionGroupTextBox.Text = vgft.VersionGroup?.Name ?? string.Empty;
        VersionGroupDetailButton.Tag = vgft.VersionGroup;
    }
    #endregion
}
