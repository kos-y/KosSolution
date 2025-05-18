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
using Kos.PokeAPI.Pokemon.Pokemon;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモンの技
/// </summary>
public partial class PokemonMoveVersionInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="version"></param>
    public PokemonMoveVersionInfoForm(PokemonMoveVersion version)
    {
        InitializeComponent();
        SetData(version);
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

    #region 技の習得方法 クリック
    /// <summary>
    /// 技の習得方法 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveLearnMethodButton_Click(object sender, EventArgs e)
    {
        if (MoveLearnMethodButton.Tag is null) {
            return;
        }

        if (MoveLearnMethodButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveLearnMethodInfoForm form = new(api.Url);
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
    /// <param name="version"></param>
    public void SetData(PokemonMoveVersion version)
    {
        Tag = version;
        FormsHelper.SetData(version.VersionGroup, VersionGroupButton, VersionGroupTextBox);
        FormsHelper.SetData(version.MoveLearnMethod, MoveLearnMethodButton, MoveLearnMethodTextBox);
        FormsHelper.SetData(version.LevelLearnedAt, LevelLearnedCaptionLabel, LevelLearnedAtTextBox);
    }
    #endregion
}
