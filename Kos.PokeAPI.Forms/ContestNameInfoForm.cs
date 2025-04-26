using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Contests.ContestTypes;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// コンテストの名前
/// </summary>
public partial class ContestNameInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="cn">コンテストの名前</param>
    public ContestNameInfoForm(ContestName cn)
    {
        InitializeComponent();
        SetData(cn);
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

    #region データに画面を表示
    /// <summary>
    /// データに画面を表示
    /// </summary>
    /// <param name="cn"></param>
    public void SetData(ContestName cn)
    {
        ContestNameTextBox.Text = cn.Name ?? string.Empty;
        ColorTextBox.Text = cn.Color ?? string.Empty;
        LanguageTextBox.Text = cn.Language?.Name ?? string.Empty;
        LanguageDetailButton.Tag = cn.Language;
    }
    #endregion
}
