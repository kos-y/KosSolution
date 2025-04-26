using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    #region 世代 詳細 クリック
    /// <summary>
    /// 世代 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GenerationDetailButton_Click(object sender, EventArgs e)
    {
        object? tag = GenerationDetailButton?.Tag;
        if (tag is null) {
            return;
        }

        if (tag is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using GenerationInfoForm form = new(api.Url);
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
    /// <param name="ggi">世代ごとのゲームインデックス</param>
    private void SetData(GenerationGameIndex ggi)
    {
        GenerationTextBox.Text = ggi.Generation?.Name ?? string.Empty;
        GenerationDetailButton.Tag = ggi.Generation;
        GameIndexTextBox.Text = $"{ggi.GameIndex}";
    }
    #endregion
}
