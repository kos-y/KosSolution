using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    #region アイテム 詳細 クリック
    /// <summary>
    /// アイテム 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemDetailButton_Click(object sender, EventArgs e)
    {
        if (ItemDetailButton.Tag is null) {
            return;
        }

        if (ItemDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技 詳細 クリック
    /// <summary>
    /// 技 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveDetailButton_Click(object sender, EventArgs e)
    {
        if (MoveDetailButton.Tag is null) {
            return;
        }

        if (MoveDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }
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
        Machine? m = Machine.GetResource(url);
        if (m is null) {
            return;
        }

        IdTextBox.Text = $"{m.Id}";
        ItemTextBox.Text = m.Item?.Name ?? string.Empty;
        ItemDetailButton.Tag = m.Item;
        MoveTextBox.Text = m.Move?.Name ?? string.Empty;
        MoveDetailButton.Tag = m.Move;
        VersionGroupTextBox.Text = m.VersionGroup?.Name ?? string.Empty;
        VersionGroupDetailButton.Tag = m.VersionGroup;
    }
    #endregion
}
