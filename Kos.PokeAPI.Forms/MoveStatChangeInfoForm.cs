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
    public MoveStatChangeInfoForm(MoveStatChange msc)
    {
        InitializeComponent();
        SetData(msc);
    }
    #endregion

    #region ステータス 詳細 クリック
    /// <summary>
    /// ステータス 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StatDetailButton_Click(object sender, EventArgs e)
    {

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
    /// <param name="msc"></param>
    private void SetData(MoveStatChange msc)
    {
        StatTextBox.Text = msc.Stat?.Name ?? string.Empty;
        StatDetailButton.Tag = msc.Stat;
        ChangeTextBox.Text = $"{msc.Change}";
    }
    #endregion
}
