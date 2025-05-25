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

namespace Kos.PokeAPI.Forms.Utility.CommonModels;

/// <summary>
/// ゲーム内のインデックス
/// </summary>
public partial class VersionGameIndexInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public VersionGameIndexInfoForm(VersionGameIndex index)
    {
        InitializeComponent();
        SetData(index);
    }
    #endregion

    #region バージョン クリック
    /// <summary>
    /// バージョン クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionButton_Click(object sender, EventArgs e)
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
    /// <param name="index"></param>
    private void SetData(VersionGameIndex index)
    {
        Tag = index;
        FormsHelper.SetData(index.Version, VersionButton, VersionTextBox);
        FormsHelper.SetData(index.GameIndex, GameIndexCaptionLabel, GameIndexTextBox);
    }
    #endregion
}
