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
using Kos.PokeAPI.Pokemon.Natures;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 影響を与えるポケスロンのステータス
/// </summary>
public partial class NatureStatChangeInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public NatureStatChangeInfoForm(NatureStatChange change)
    {
        InitializeComponent();
        SetData(change);
    }
    #endregion

    /// <summary>
    /// ステータス クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokeathlonStatButton_Click(object sender, EventArgs e)
    {

    }

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
    /// <param name="change"></param>
    private void SetData(NatureStatChange change)
    {
        Tag = change;
        FormsHelper.SetData(change.PokeathlonStat, PokeathlonStatButton, PokeathlonStatTextBox);
        FormsHelper.SetData(change.MaxChange, MaxChangeCaptionLabel, MaxChangeTextBox);
    }
    #endregion
}
