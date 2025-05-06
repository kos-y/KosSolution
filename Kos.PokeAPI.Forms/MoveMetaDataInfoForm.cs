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
/// 技の詳細
/// </summary>
public partial class MoveMetaDataInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="mmd"></param>
    public MoveMetaDataInfoForm(MoveMetaData mmd)
    {
        InitializeComponent();
        SetData(mmd);
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
    /// <param name="mmd"></param>
    private void SetData(MoveMetaData mmd)
    {
        CategoryTextBox.Text = mmd.Category?.Name ?? string.Empty;
        CategoryDetailButton.Tag = mmd.Category;
        MaxHitsTextBox.Text = $"{mmd.MaxHits}";
        MinHitsTextBox.Text = $"{mmd.MinHits}";
        MaxTurnsTextBox.Text = $"{mmd.MaxTurns}";
        MinTurnsTextBox.Text = $"{mmd.MinTurns}";
        CritRateTextBox.Text = $"{mmd.CritRate}";
        DrainTextBox.Text = $"{mmd.Drain}";
        AilmentTextBox.Text = mmd.Ailment?.Name ?? string.Empty;
        AilmentDetailButton.Tag = mmd.Ailment;
        AilmentChanceTextBox.Text = $"{mmd.AilmentChance}";
        FlinchChanceTextBox.Text = $"{mmd.FlinchChance}";
        StatChanceTextBox.Text = $"{mmd.StateChance}";
    }
    #endregion
}
