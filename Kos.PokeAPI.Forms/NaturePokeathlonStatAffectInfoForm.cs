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
using Kos.PokeAPI.Pokemon.PokeathlonStats;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 性格が影響を与えるポケスロンのステータス
/// </summary>
public partial class NaturePokeathlonStatAffectInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="affect"></param>
    public NaturePokeathlonStatAffectInfoForm(NaturePokeathlonStatAffect affect)
    {
        InitializeComponent();
        SetData(affect);
    }
    #endregion

    #region 性格 クリック
    /// <summary>
    /// 性格 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NatureButton_Click(object sender, EventArgs e)
    {
        if (NatureButton.Tag is null) {
            return;
        }

        if (NatureButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using NatureInfoForm form = new(api.Url);
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
    /// <param name="affect"></param>
    private void SetData(NaturePokeathlonStatAffect affect)
    {
        Tag = affect;
        FormsHelper.SetData(affect.Nature, NatureButton, NatureTextBox);
        FormsHelper.SetData(affect.MaxChange, MaxChangeCaptionLabel, MaxChangeTextBox);
    }
    #endregion
}
