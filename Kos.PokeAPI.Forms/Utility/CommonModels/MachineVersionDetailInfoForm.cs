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
/// バージョンごとの技マシン情報
/// </summary>
public partial class MachineVersionDetailInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="detail"></param>
    public MachineVersionDetailInfoForm(MachineVersionDetail detail)
    {
        InitializeComponent();
        SetData(detail);
    }
    #endregion

    #region バージョングループ クリック
    /// <summary>
    /// バージョングループ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupButton_Click(object sender, EventArgs e)
    {
        if (VersionGroupButton.Tag is null) {
            return;
        }

        if (VersionGroupButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技マシン クリック
    /// <summary>
    /// 技マシン クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MachineButton_Click(object sender, EventArgs e)
    {
        if (MachineButton.Tag is null) {
            return;
        }

        if (MachineButton.Tag is not APIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MachineInfoForm form = new(api.Url);
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
    /// <param name="detail"></param>
    private void SetData(MachineVersionDetail detail)
    {
        Tag = detail;
        FormsHelper.SetData(detail.VersionGroup, VersionGroupButton, VersionGroupTextBox);
        FormsHelper.SetData(detail.Machine, MachineButton);
    }
    #endregion
}
