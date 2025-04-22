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

    #region Form Load
    /// <summary>
    /// Form Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EvolutionChainInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region baby_trigger_item Info Click
    /// <summary>
    /// baby_trigger_item Info Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BabyTriggerItemInfoButton_Click(object sender, EventArgs e)
    {

    }
    #endregion

    /// <summary>
    /// Chain Info Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChainInfoButton_Click(object sender, EventArgs e)
    {
        if (ChainInfoButton.Tag is not ChainLink tag) {
            return;
        }

        using ChainLinkInfoForm form = new(tag);
        _ = form.ShowDialog(this);
    }

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

        IdLabel.Text = $"{ec.Id}";
        BabyTriggerItemLabel.Text = ec.BabyTriggerItem?.Name ?? string.Empty;
        BabyTriggerItemInfoButton.Tag = ec.BabyTriggerItem;
        ChainLabel.Text = ec.Chain?.ToString() ?? string.Empty;
        ChainInfoButton.Tag = ec.Chain;
    }
    #endregion
}
