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

    #region 進化発動条件 クリック
    /// <summary>
    /// 進化発動条件 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TriggerButton_Click(object sender, EventArgs e)
    {
        if (TriggerButton.Tag is null) {
            return;
        }

        if (TriggerButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EvolutionTriggerInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 覚えている技 技 クリック
    /// <summary>
    /// 覚えている技 技 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void KnownMoveButton_Click(object sender, EventArgs e)
    {
        if (KnownMoveButton.Tag is null) {
            return;
        }

        if (KnownMoveButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 覚えている技 タイプ クリック
    /// <summary>
    /// 覚えている技 タイプ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void KnownMoveTypeButton_Click(object sender, EventArgs e)
    {
        if (KnownMoveTypeButton.Tag is null) {
            return;
        }

        if (KnownMoveTypeButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }
    }
    #endregion

    #region アイテム 使用 クリック
    /// <summary>
    /// アイテム 使用 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemButton_Click(object sender, EventArgs e)
    {
        if (ItemButton.Tag is null) {
            return;
        }

        if (ItemButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ItemInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region アイテム 所持 クリック
    /// <summary>
    /// アイテム 所持 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HeldItemButton_Click(object sender, EventArgs e)
    {
        if (HeldItemButton.Tag is null) {
            return;
        }

        if (HeldItemButton.Tag is not NamedAPIResource api) {
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
        if (LocationButton.Tag is null) {
            return;
        }

        if (LocationButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using LocationInfoForm form = new(api.Url);
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
    private void SetData(EvolutionDetail detail)
    {
        Tag = detail;
        FormsHelper.SetData(detail.Trigger, TriggerButton, TriggerTextBox);
        FormsHelper.SetData(detail.Gender, GenderCaptionLabel, GenderTextBox);
        FormsHelper.SetData(detail.MinLevel, MinLevelCaptionLabel, MinLevelTextBox);
        FormsHelper.SetData(detail.MinHappiness, MinHappinessCaptionLabel, MinHappinessTextBox);
        FormsHelper.SetData(detail.MinBeauty, MinBeautyCaptionLabel, MinBeautyTextBox);
        FormsHelper.SetData(detail.MinAffection, MinAffectionCaptionLabel, MinAffectionTextBox);
        FormsHelper.SetData(
            detail.RelativePhysicalStats,
            RelativePhysicalStatsCaptionLabel,
            RelativePhysicalStatsTextBox);
        FormsHelper.SetData(detail.KnownMove, KnownMoveButton, KnownMoveTextBox);
        FormsHelper.SetData(detail.KnownMoveType, KnownMoveTypeButton, KnownMoveTypeTextBox);
        FormsHelper.SetData(detail.Item, ItemButton, ItemTextBox);
        FormsHelper.SetData(detail.HeldItem, HeldItemButton, HeldItemTextBox);
        FormsHelper.SetData(detail.PartySpecies, PartySpeciesButton, PartySpeciesTextBox);
        FormsHelper.SetData(detail.PartyType, PartyTypeButton, PartyTypeTextBox);
        FormsHelper.SetData(detail.TradeSpecies, TradeSpeciesDetailButton, TradeSpeciesTextBox);
        FormsHelper.SetData(detail.Location, LocationButton, LocationTextBox);
        FormsHelper.SetData(
            detail.NeedsOverworldRain,
            NeedsOverworldRainCaptionLabel,
            NeedsOverworldRainTextBox);
        FormsHelper.SetData(detail.TimeOfDay, TimeOfDayCaptionLabel, TimeOfDayTextBox);
        FormsHelper.SetData(detail.TurnUpsideDown, TurnUpsideDownCaptionlabel, TurnUpsideDownTextBox);
    }
    #endregion
}
