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
using Kos.PokeAPI.Games.Generations;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 世代ごとのゲームインデックス
/// </summary>
public partial class GenerationGameIndexInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ggi">世代ごとのゲームインデックス</param>
    public GenerationGameIndexInfoForm(GenerationGameIndex ggi)
    {
        InitializeComponent();
        SetData(ggi);
    }
    #endregion

    #region 世代 クリック
    /// <summary>
    /// 世代 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GenerationButton_Click(object sender, EventArgs e)
    {
        if (GenerationButton?.Tag is null) {
            return;
        }

        if (GenerationButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using GenerationInfoForm form = new(api.Url);
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

    #region 画面にデータの設定
    /// <summary>
    /// 画面にデータの設定
    /// </summary>
    /// <param name="index">世代ごとのゲームインデックス</param>
    private void SetData(GenerationGameIndex index)
    {
        Tag = index;
        FormsHelper.SetData(index.Generation, GenerationButton, GenerationTextBox);
        FormsHelper.SetData(index.GameIndex, GameIndexCaptionLabel, GameIndexTextBox);
    }
    #endregion
}
