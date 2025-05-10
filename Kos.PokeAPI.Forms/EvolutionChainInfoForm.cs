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
        if (BabyTriggerItemButton.Tag is null) {
            return;
        }

        if (BabyTriggerItemButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 進化チェーン クリック
    /// <summary>
    /// 進化チェーン　クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChainButton_Click(object sender, EventArgs e)
    {
        if (ChainButton.Tag is null) {
            return;
        }

        if (ChainButton.Tag is not ChainLink cl) {
            return;
        }

        using ChainLinkInfoForm form = new(cl);
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

    #region データの表示
    /// <summary>
    /// データの表示
    /// </summary>
    /// <param name="url">URL</param>
    public void SetData(string url)
    {
        EvolutionChain? chain = EvolutionChain.GetEvolutionChain(url);
        if (chain is null) {
            return;
        }

        Tag = chain;
        FormsHelper.SetData(chain.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(chain.BabyTriggerItem, BabyTriggerItemButton, BabyTriggerItemTextBox);
        FormsHelper.SetData(chain.Chain, ChainButton, ChainTextBox);
    }
    #endregion
}
