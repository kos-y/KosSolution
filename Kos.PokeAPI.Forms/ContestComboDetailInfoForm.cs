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
/// コンテストのコンボ詳細
/// </summary>
public partial class ContestComboDetailInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="combo"></param>
    public ContestComboDetailInfoForm(ContestComboDetail combo)
    {
        InitializeComponent();
        SetData(combo);
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
    /// <param name="combo"></param>
    private void SetData(ContestComboDetail combo)
    {
        Tag = combo;
        FormsHelper.SetData(combo.UseBefore, UseBeforeCaptionLabel, UseBeforeDataGridView);
        FormsHelper.SetData(combo.UseAfter, UseAfterCaptionLabel, UseAfterDataGridView);
    }
    #endregion
}
