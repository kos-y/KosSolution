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
/// コンテストのコンボ詳細
/// </summary>
public partial class ContestComboDetailInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ccd"></param>
    public ContestComboDetailInfoForm(ContestComboDetail ccd)
    {
        InitializeComponent();
        SetData(ccd);
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
    /// <param name="ccd"></param>
    private void SetData(ContestComboDetail ccd)
    {
        UseBeforeDataGridView.AutoGenerateColumns = false;
        UseBeforeDataGridView.DataSource = ccd.UseBefore;
        UseAfterDataGridView.AutoGenerateColumns = false;
        UseAfterDataGridView.DataSource = ccd.UseAfter;
    }
    #endregion
}
