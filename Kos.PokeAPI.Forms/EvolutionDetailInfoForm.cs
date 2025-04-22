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

    #region Close Click
    /// <summary>
    /// Close Click
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
        ItemLabel.Text = ed.Item?.Name ?? string.Empty;
        ItemInfoButton.Tag = ed.Item;
        TriggerLabel.Text = ed.Trigger?.Name ?? string.Empty;
        TriggerInfoButton.Tag = ed.Trigger;
        GenderLabel.Text = $"{ed.Gender}";
        HeldItemLabel.Text = ed.HeldItem?.Name ?? string.Empty;
        HeldItemInfoButton.Tag = ed.HeldItem;
        KnownMoveLabel.Text = ed.KnownMove?.Name ?? string.Empty;
        KnownMoveInfoButton.Tag = ed.KnownMove;
        KnownMoveTypeLabel.Text = ed.KnownMoveType?.Name ?? string.Empty;
        KnownMoveTypeInfoButton.Tag = ed.KnownMoveType;
        LocationLabel.Text = ed.Location?.Name ?? string.Empty;
        MinLevelLabel.Text = $"{ed.MinLevel}";
        MinHappinessLabel.Text = $"{ed.MinHappiness}";
        MinBeautyLabel.Text = $"{ed.MinBeauty}";
        MinAffectionLabel.Text = $"{ed.MinAffection}";
        NeedsOverworldRainLabel.Text = $"{ed.NeedsOverworldRain}";
        PartySpeciesLabel.Text = ed.PartySpecies?.Name ?? string.Empty;
        PartySpeciesInfoButton.Tag = ed.PartySpecies;
        PartyTypeLabel.Text = ed.PartyType?.Name ?? string.Empty;
        PartyTypeInfoButton.Tag = ed.PartyType;
        RelativePhysicalStatsLabel.Text = $"{ed.RelativePhysicalStats}";
        TimeOfDayLabel.Text = ed.TimeOfDay ?? string.Empty;
        TradeSpeciesLabel.Text = ed.TradeSpecies?.Name ?? string.Empty;
        TradeSpeciesInfoButton.Tag = ed.TradeSpecies;
        TurnUpsideDownLabel.Text = $"{ed.TurnUpsideDown}";
    }
    #endregion
}
