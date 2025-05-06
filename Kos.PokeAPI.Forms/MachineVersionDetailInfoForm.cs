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
/// バージョンごとの技マシン情報
/// </summary>
public partial class MachineVersionDetailInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="mvd"></param>
    public MachineVersionDetailInfoForm(MachineVersionDetail mvd)
    {
        InitializeComponent();
        SetData(mvd);
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

        using VersionGroupInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技マシン 詳細 クリック
    /// <summary>
    /// 技マシン 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MachineDetailButton_Click(object sender, EventArgs e)
    {
        if (MachineDetailButton.Tag is null) {
            return;
        }

        if (MachineDetailButton.Tag is not APIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MachineInfoForm form = new(api.Url);
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
    /// <param name="mvd"></param>
    private void SetData(MachineVersionDetail mvd)
    {
        VersionGroupTextBox.Text = mvd.VersionGroup?.Name ?? string.Empty;
        VersionGroupDetailButton.Tag = mvd.VersionGroup;
        MachineDetailButton.Tag = mvd.Machine;
    }
    #endregion
}
