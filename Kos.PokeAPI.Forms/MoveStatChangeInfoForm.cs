using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Kos.Core.Forms;
using Kos.PokeAPI.Moves.Moves;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 技が影響を与えるステータス
/// </summary>
public partial class MoveStatChangeInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MoveStatChangeInfoForm(MoveStatChange change)
    {
        InitializeComponent();
        SetData(change);
    }
    #endregion

    #region ステータス クリック
    /// <summary>
    /// ステータス クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StatButton_Click(object sender, EventArgs e)
    {

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

        PropertyGridForm form = new(Tag);
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
    /// <param name="change"></param>
    private void SetData(MoveStatChange change)
    {
        Tag = change;
        FormsHelper.SetData(change.Stat, StatButton, StatTextBox);
        FormsHelper.SetData(change.Change, ChangeCaptionLabel, ChangeTextBox);
    }
    #endregion
}
