using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Moves.Moves;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// コンテストのコンボセット
/// </summary>
public partial class ContestComboSetsInfoForm : Form
{
    #region コンテスト
    /// <summary>
    /// コンテスト
    /// </summary>
    /// <param name="ccs"></param>
    public ContestComboSetsInfoForm(ContestComboSets ccs)
    {
        InitializeComponent();
    }
    #endregion

    #region ポケモンコンテスト 詳細 クリック
    /// <summary>
    /// ポケモンコンテスト 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NormalDetailButton_Click(object sender, EventArgs e)
    {
        if (NormalDetailButton.Tag is null) {
            return;
        }

        if (NormalDetailButton.Tag is not ContestComboDetail ccd) {
            return;
        }

        using ContestComboDetailInfoForm form = new(ccd);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region スーパーコンテスト 詳細 クリック
    /// <summary>
    /// スーパーコンテスト 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SuperDetailButton_Click(object sender, EventArgs e)
    {
        if (SuperDetailButton.Tag is null) {
            return;
        }

        if (SuperDetailButton.Tag is not ContestComboDetail ccd) {
            return;
        }

        using ContestComboDetailInfoForm form = new(ccd);
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
    /// <param name="ccs"></param>
    private void SetData(ContestComboSets ccs)
    {
        NormalDetailButton.Tag = ccs.Normal;
        SuperDetailButton.Tag = ccs.Super;
    }
    #endregion
}
