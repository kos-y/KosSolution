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
using Kos.PokeAPI.Moves.Moves;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// コンテストのコンボセット
/// </summary>
public partial class ContestComboSetsInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="sets"></param>
    public ContestComboSetsInfoForm(ContestComboSets sets)
    {
        InitializeComponent();
        SetData(sets);
    }
    #endregion

    #region ポケモンコンテスト クリック
    /// <summary>
    /// ポケモンコンテスト クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NormalButton_Click(object sender, EventArgs e)
    {
        if (NormalButton.Tag is null) {
            return;
        }

        if (NormalButton.Tag is not ContestComboDetail ccd) {
            return;
        }

        using ContestComboDetailInfoForm form = new(ccd);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region スーパーコンテスト クリック
    /// <summary>
    /// スーパーコンテスト クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SuperButton_Click(object sender, EventArgs e)
    {
        if (SuperButton.Tag is null) {
            return;
        }

        if (SuperButton.Tag is not ContestComboDetail ccd) {
            return;
        }

        using ContestComboDetailInfoForm form = new(ccd);
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
    /// <param name="sets"></param>
    private void SetData(ContestComboSets sets)
    {
        Tag = sets;
        FormsHelper.SetData(sets.Normal, NormalButton);
        FormsHelper.SetData(sets.Super, SuperButton);
    }
    #endregion
}
