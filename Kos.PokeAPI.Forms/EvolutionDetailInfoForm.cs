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
/// 進化詳細
/// </summary>
public partial class EvolutionDetailInfoForm : Form
{
    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ed">進化詳細</param>
    public EvolutionDetailInfoForm(EvolutionDetail ed)
    {
        InitializeComponent();
        SetData(ed);
    }
    #endregion

    #region アイテム 詳細 クリック
    /// <summary>
    /// アイテム 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemDetailButton_Click(object sender, EventArgs e)
    {
        if (ItemDetailButton.Tag is null) {
            return;
        }

        if (ItemDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region トリガー 詳細 クリック
    /// <summary>
    /// トリガー 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TriggerDetailButton_Click(object sender, EventArgs e)
    {
        if (TriggerDetailButton.Tag is null) {
            return;
        }

        if (TriggerDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EvolutionTriggerInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 所持アイテム 詳細 クリック
    /// <summary>
    /// 所持アイテム 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HeldItemDetailButton_Click(object sender, EventArgs e)
    {
        if (HeldItemDetailButton.Tag is null) {
            return;
        }

        if (HeldItemDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 場所 詳細 クリック
    /// <summary>
    /// 場所 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LocationDetailButton_Click(object sender, EventArgs e)
    {
        if (LocationDetailButton.Tag is null) {
            return;
        }

        if (LocationDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using LocationInfoForm form = new(api.Url);
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
    private void SetData(EvolutionDetail ed)
    {
        ItemTextBox.Text = ed.Item?.Name ?? string.Empty;
        ItemDetailButton.Tag = ed.Item;
        TriggerTextBox.Text = ed.Trigger?.Name ?? string.Empty;
        TriggerDetailButton.Tag = ed.Trigger;
        GenderTextBox.Text = $"{ed.Gender}";
        HeldItemTextBox.Text = ed.HeldItem?.Name ?? string.Empty;
        HeldItemDetailButton.Tag = ed.HeldItem;
        KnownMoveTextBox.Text = ed.KnownMove?.Name ?? string.Empty;
        KnownMoveDetailButton.Tag = ed.KnownMove;
        KnownMoveTypeTextBox.Text = ed.KnownMoveType?.Name ?? string.Empty;
        KnownMoveTypeDetailButton.Tag = ed.KnownMoveType;
        LocationTextBox.Text = ed.Location?.Name ?? string.Empty;
        LocationDetailButton.Tag = ed.Location;
        MinLevelTextBox.Text = $"{ed.MinLevel}";
        MinHappinessTextBox.Text = $"{ed.MinHappiness}";
        MinBeautyTextBox.Text = $"{ed.MinBeauty}";
        MinAffectionTextBox.Text = $"{ed.MinBeauty}";
        NeedsOverworldRainTextBox.Text = $"{ed.NeedsOverworldRain}";
        PartySpeciesTextBox.Text = ed.PartySpecies?.Name ?? string.Empty;
        PartySpeciesDetailButton.Tag = ed.PartySpecies;
        PartyTypeTextBox.Text = ed.PartyType?.Name ?? string.Empty;
        PartyTypeDetailButton.Tag = ed.PartyType;
        RelativePhysicalStatsTextBox.Text = $"{ed.RelativePhysicalStats}";
        TimeOfDayTextBox.Text = ed.TimeOfDay ?? string.Empty;
        TradeSpeciesTextBox.Text = ed.TradeSpecies?.Name ?? string.Empty;
        TradeSpeciesDetailButton.Tag = ed.TradeSpecies;
        TurnUpsideDownTextBox.Text = $"{ed.TurnUpsideDown}";
    }
    #endregion
}
