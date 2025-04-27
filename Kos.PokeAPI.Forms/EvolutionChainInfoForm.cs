using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Evolution.EvolutionChains;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 進化チェーン
/// </summary>
public partial class EvolutionChainInfoForm : Form
{
    // フィールド

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url;
    #endregion

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public EvolutionChainInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region ロード
    /// <summary>
    /// ロード
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EvolutionChainInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region ベビーポケモン進化トリガーアイテム 詳細 クリック
    /// <summary>
    /// ベビーポケモン進化トリガーアイテム 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BabyTriggerItemDetailButton_Click(object sender, EventArgs e)
    {
        if (BabyTriggerItemDetailButton.Tag is null) {
            return;
        }

        if (BabyTriggerItemDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 進化チェーン 詳細　クリック
    /// <summary>
    /// 進化チェーン 詳細　クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChainDetailButton_Click(object sender, EventArgs e)
    {
        if (ChainDetailButton.Tag is null) {
            return;
        }

        if (ChainDetailButton.Tag is not ChainLink cl) {
            return;
        }

        using ChainLinkInfoForm form = new(cl);
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

    #region データの表示
    /// <summary>
    /// データの表示
    /// </summary>
    /// <param name="url">URL</param>
    public void SetData(string url)
    {
        EvolutionChain? ec = EvolutionChain.GetEvolutionChain(url);
        if (ec is null) {
            return;
        }

        IdTextBox.Text = $"{ec.Id}";
        BabyTriggerItemTextBox.Text = ec.BabyTriggerItem?.Name ?? string.Empty;
        BabyTriggerItemDetailButton.Tag = ec.BabyTriggerItem;
        ChainTextBox.Text = ec.Chain?.ToString() ?? string.Empty;
        ChainDetailButton.Tag = ec.Chain;
    }
    #endregion
}
