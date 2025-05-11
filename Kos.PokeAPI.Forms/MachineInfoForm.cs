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
using Kos.PokeAPI.Machines.Machines;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 技マシン
/// </summary>
public partial class MachineInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url"></param>
    public MachineInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region アイテム クリック
    /// <summary>
    /// アイテム クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemButton_Click(object sender, EventArgs e)
    {
        if (ItemButton.Tag is null) {
            return;
        }

        if (ItemButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技 クリック
    /// <summary>
    /// 技 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveButton_Click(object sender, EventArgs e)
    {
        if (MoveButton.Tag is null) {
            return;
        }

        if (MoveButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
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
    /// <param name="url"></param>
    private void SetData(string url)
    {
        Machine? machine = Machine.GetResource(url);
        if (machine is null) {
            return;
        }

        Tag = machine;
        FormsHelper.SetData(machine.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(machine.Item, ItemButton, ItemTextBox);
        FormsHelper.SetData(machine.Move, MoveButton, MoveTextBox);
        FormsHelper.SetData(machine.VersionGroup, VersionGroupButton, VersionGroupTextBox);
    }
    #endregion
}
