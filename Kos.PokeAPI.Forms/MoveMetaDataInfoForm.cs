using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.Core.Forms;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 技の詳細
/// </summary>
public partial class MoveMetaDataInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="mmd"></param>
    public MoveMetaDataInfoForm(MoveMetaData mmd)
    {
        InitializeComponent();
        SetData(mmd);
    }
    #endregion

    #region カテゴリー クリック
    /// <summary>
    /// カテゴリー クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CategoryButton_Click(object sender, EventArgs e)
    {
        if (CategoryButton.Tag is null) {
            return;
        }

        if (CategoryButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveCategoryInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 状態異常 クリック
    /// <summary>
    /// 状態異常 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AilmentButton_Click(object sender, EventArgs e)
    {
        if (AilmentButton.Tag is null) {
            return;
        }

        if (AilmentButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveAilmentInfoForm form = new(api.Url);
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
    /// <param name="meta"></param>
    private void SetData(MoveMetaData meta)
    {
        Tag = meta;
        FormsHelper.SetData(meta.Category, CategoryButton, CategoryTextBox);
        FormsHelper.SetData(
            meta.MinHits, meta.MaxHits,
            HitsCaptionLabel, MinHitsTextBox, HitsRangeLabel, MaxHitsTextBox);
        FormsHelper.SetData(
            meta.MinTurns, meta.MaxTurns,
            TurnCaptionLabel, MinTurnsTextBox, TurnsRangeLabel, MaxTurnsTextBox);
        FormsHelper.SetData(meta.CritRate, CritRateCaptionLabel, CritRateTextBox);
        FormsHelper.SetData(meta.Drain, DrainCaptionLabel, DrainTextBox);
        FormsHelper.SetData(meta.Healing, HealingCaptionLabel, HealingTextBox);
        FormsHelper.SetData(meta.Ailment, AilmentButton, AilmentTextBox);
        FormsHelper.SetData(meta.AilmentChance, AilmentChanceCaptionLabel, AilmentChanceTextBox);
        FormsHelper.SetData(meta.FlinchChance, FlinchChanceCaptionLabel, FlinchChanceTextBox);
        FormsHelper.SetData(meta.StateChance, StateChanceCaptionLabel, StatChanceTextBox);
    }
    #endregion
}
