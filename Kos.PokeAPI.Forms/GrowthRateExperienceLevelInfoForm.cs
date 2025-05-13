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
using Kos.PokeAPI.Pokemon.GrowthRates;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// レベルごとの必要な経験値
/// </summary>
public partial class GrowthRateExperienceLevelInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public GrowthRateExperienceLevelInfoForm(GrowthRateExperienceLevel exp)
    {
        InitializeComponent();
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
    /// <param name="exp"></param>
    private void SetData(GrowthRateExperienceLevel exp)
    {
        Tag = exp;
        FormsHelper.SetData(exp.Level, LevelCaptionLabel, LevelTextBox);
        FormsHelper.SetData(exp.Experience, ExperienceCaptionLabel, ExperienceTextBox);
    }
    #endregion
}
