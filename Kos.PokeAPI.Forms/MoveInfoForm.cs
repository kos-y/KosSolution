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
using Kos.PokeAPI.Forms.Utility.CommonModels;
using Kos.PokeAPI.Moves.Moves;
using Kos.PokeAPI.Pokemon.Abilities;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 技
/// </summary>
public partial class MoveInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url"></param>
    public MoveInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region タイプ クリック
    /// <summary>
    /// タイプ 種別 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TypeButton_Click(object sender, EventArgs e)
    {

    }
    #endregion

    #region 技の詳細情報 クリック
    /// <summary>
    /// 技の詳細情報 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MetaButton_Click(object sender, EventArgs e)
    {
        if (MetaButton.Tag is null) {
            return;
        }

        if (MetaButton.Tag is not MoveMetaData meta) {
            return;
        }

        using MoveMetaDataInfoForm form = new(meta);
        _ = form.ShowDialog(this);
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
        if (GenerationButton.Tag is null) {
            return;
        }

        if (GenerationButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using GenerationInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 対象 クリック
    /// <summary>
    /// 対象 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TargetButton_Click(object sender, EventArgs e)
    {
        if (TargetButton.Tag is null) {
            return;
        }

        if (TargetButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveTargetInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ダメージの種類 クリック
    /// <summary>
    /// ダメージの種類 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DamageClassButton_Click(object sender, EventArgs e)
    {
        if (DamageClassButton.Tag is null) {
            return;
        }

        if (DamageClassButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveDamageClassInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region コンテストの種類 クリック
    /// <summary>
    /// コンテストの種類 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestTypeButton_Click(object sender, EventArgs e)
    {
        if (ContestTypeButton.Tag is null) {
            return;
        }

        if (ContestTypeButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ContestTypeInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region コンテスト コンボ クリック
    /// <summary>
    /// コンテスト コンボ クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestCombosButton_Click(object sender, EventArgs e)
    {
        if (ContestCombosButton.Tag is null) {
            return;
        }

        if (ContestCombosButton.Tag is not ContestComboSets combo) {
            return;
        }

        using ContestComboSetsInfoForm form = new(combo);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ポケモンコンテスト 効果 クリック
    /// <summary>
    /// ポケモンコンテスト 効果 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestEffectButton_Click(object sender, EventArgs e)
    {
        if (ContestEffectButton.Tag is null) {
            return;
        }

        if (ContestEffectButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ContestEffectInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region スーパーコンテスト 効果 クリック
    /// <summary>
    /// スーパーコンテスト 効果 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SuperContestEffectButton_Click(object sender, EventArgs e)
    {
        if (SuperContestEffectButton.Tag is null) {
            return;
        }

        if (SuperContestEffectButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using SuperContestEffectInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの名前 セルクリック
    /// <summary>
    /// 言語ごとの名前 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NamesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (NamesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        using NameInfoForm form = new(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 言語ごとの名前 セルダブルクリック
    /// <summary>
    /// 言語ごとの名前 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NamesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (NamesDataGridView.Rows[e.RowIndex].DataBoundItem is not Name name) {
            return;
        }

        using NameInfoForm form = new(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region フレーバーテキスト セルクリック
    /// <summary>
    /// フレーバーテキスト セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        FlavorTextEntriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not
            MoveFlavorText mft) {
            return;
        }

        using MoveFlavorTextInfoForm form = new(mft);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region フレーバーテキスト セルダブルクリック
    /// <summary>
    /// フレーバーテキスト セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        FlavorTextEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not
            MoveFlavorText mft) {
            return;
        }

        using MoveFlavorTextInfoForm form = new(mft);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 効果 セルクリック
    /// <summary>
    /// 効果 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectEntriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not VerboseEffect ve) {
            return;
        }

        using VerboseEffectInfoForm form = new(ve);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 効果 セルダブルクリック
    /// <summary>
    /// 効果 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not VerboseEffect ve) {
            return;
        }

        using VerboseEffectInfoForm form = new(ve);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 効果変更 セルクリック
    /// <summary>
    /// 効果変更 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectChangesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EffectChangesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (EffectChangesDataGridView.Rows[e.RowIndex].DataBoundItem is not
            AbilityEffectChange aec) {
            return;
        }

        using AbilityEffectChangeInfoForm form = new(aec);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 効果変更 セルダブルクリック
    /// <summary>
    /// 効果変更 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EffectChangesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EffectChangesDataGridView.Rows[e.RowIndex].DataBoundItem is not
            AbilityEffectChange aec) {
            return;
        }

        using AbilityEffectChangeInfoForm form = new(aec);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技マシン セルクリック
    /// <summary>
    /// 技マシン セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MachinesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (MachinesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (MachinesDataGridView.Rows[e.RowIndex].DataBoundItem is not MachineVersionDetail mvd) {
            return;
        }

        using MachineVersionDetailInfoForm form = new(mvd);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技マシン セルダブルクリック
    /// <summary>
    /// 技マシン セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MachinesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (MachinesDataGridView.Rows[e.RowIndex].DataBoundItem is not MachineVersionDetail mvd) {
            return;
        }

        using MachineVersionDetailInfoForm form = new(mvd);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ステータス変更 セルクリック
    /// <summary>
    /// ステータス変更 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StatChangeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (StatChangeDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (StatChangeDataGridView.Rows[e.RowIndex].DataBoundItem is not MoveStatChange msc) {
            return;
        }

        using MoveStatChangeInfoForm form = new(msc);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ステータス変更 セルダブルクリック
    /// <summary>
    /// ステータス変更 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StatChangeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (StatChangeDataGridView.Rows[e.RowIndex].DataBoundItem is not MoveStatChange msc) {
            return;
        }

        using MoveStatChangeInfoForm form = new(msc);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 過去のステータス変更 セルクリック
    /// <summary>
    /// 過去のステータス変更 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PastValuesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (PastValuesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (PastValuesDataGridView.Rows[e.RowIndex].DataBoundItem is not PastMoveStatValues pmsv) {
            return;
        }

        using PastMoveStatValuesInfoForm form = new(pmsv);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 過去のステータス変更 セルダブルクック
    /// <summary>
    /// 過去のステータス変更 セルダブルクック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PastValuesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (PastValuesDataGridView.Rows[e.RowIndex].DataBoundItem is not PastMoveStatValues pmsv) {
            return;
        }

        using PastMoveStatValuesInfoForm form = new(pmsv);
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
    /// <param name="url"></param>
    private void SetData(string url)
    {
        Move? move = Moves.Moves.Move.GetResource(url);
        if (move is null) {
            return;
        }

        Tag = move;
        FormsHelper.SetData(move.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(move.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(move.Type, TypeButton, TypeTextBox);
        FormsHelper.SetData(move.PP, PPCaptionLabel, PPTextBox);
        FormsHelper.SetData(move.Meta, MetaButton);
        FormsHelper.SetData(move.Accurary, AccuracyCaptionLabel, AccuracyTextBox);
        FormsHelper.SetData(move.Power, PowerCaptionLabel, PowerTextBox);
        FormsHelper.SetData(move.Generation, GenerationButton, GenerationTextBox);
        FormsHelper.SetData(move.Target, TargetButton, TargetTextBox);
        FormsHelper.SetData(move.EffectChance, EffectChanceCaptionLabel, EffectChanceTextBox);
        FormsHelper.SetData(move.Priority, PriorityCaptionLabel, PriorityTextBox);
        FormsHelper.SetData(move.DamageClass, DamageClassButton, DamageClassTextBox);
        FormsHelper.SetData(move.ContestType, ContestTypeButton, ContestTypeTextBox);
        FormsHelper.SetData(move.ContestCombos, ContestCombosButton);
        FormsHelper.SetData(move.ContestEffect, ContestEffectButton, ContestEffectTextBox);
        FormsHelper.SetData(move.SuperContestEffect, SuperContestEffectButton, SuperContestEffectTextBox);
        FormsHelper.SetData(move.Names, NamesCaptionLabel, NamesDataGridView);
        FormsHelper.SetData(move.LearnedByPokemon, LearnedByPokemonCaptionLabel, LearnedByPokemonDataGridView);
        FormsHelper.SetData(move.FlavorTextEntries, FlavorTextEntriesDataGridView);
        FormsHelper.SetData(move.EffectEntries, EffectEntriesDataGridView);
        FormsHelper.SetData(move.EffectChanges, EffectChangesDataGridView);
        FormsHelper.SetData(move.Machines, MachinesDataGridView);
        FormsHelper.SetData(move.StatChanges, StatChangeDataGridView);
        FormsHelper.SetData(move.PastValues, PastValuesDataGridView);
    }
    #endregion
}
