using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    #region タイプ 種別 クリック
    /// <summary>
    /// タイプ 種別 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TypeDetailButton_Click(object sender, EventArgs e)
    {

    }
    #endregion

    #region 技の詳細情報 クリック
    /// <summary>
    /// 技の詳細情報 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MetaDetailButton_Click(object sender, EventArgs e)
    {
        if (MetaDetailButton.Tag is null) {
            return;
        }

        if (MetaDetailButton.Tag is not MoveMetaData meta) {
            return;
        }

        using MoveMetaDataInfoForm form = new(meta);
        _ = form.ShowDialog(this);
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
        if (GenerationDetailButton.Tag is null) {
            return;
        }

        if (GenerationDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using GenerationInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region コンテスト 種類 詳細 クリック
    /// <summary>
    /// コンテストの種類 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestTypeDetailButton_Click(object sender, EventArgs e)
    {
        if (ContestTypeDetailButton.Tag is null) {
            return;
        }

        if (ContestTypeDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ContestTypeInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region コンテスト コンボ 詳細 クリック
    /// <summary>
    /// コンテスト コンボ 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestCombosDetailButton_Click(object sender, EventArgs e)
    {
        if (ContestCombosDetailButton.Tag is null) {
            return;
        }

        if (ContestCombosDetailButton.Tag is not ContestComboSets ccs) {
            return;
        }

        using ContestComboSetsInfoForm form = new(ccs);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ポケモンコンテスト 効果 詳細 クリック
    /// <summary>
    /// ポケモンコンテスト 効果 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestEffectDetailButton_Click(object sender, EventArgs e)
    {
        if (ContestEffectDetailButton.Tag is null) {
            return;
        }

        if (ContestEffectDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using ContestEffectInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region スーパーコンテスト 効果 詳細 クリック
    /// <summary>
    /// スーパーコンテスト 効果 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SuperContestEffectDetailButton_Click(object sender, EventArgs e)
    {
        if (SuperContestEffectDetailButton.Tag is null) {
            return;
        }

        if (SuperContestEffectDetailButton.Tag is not NamedAPIResource api) {
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

        IdTextBox.Text = $"{move.Id}";
        NameTextBox.Text = move.Name;
        TypeTextBox.Text = move.Type?.Name ?? string.Empty;
        TypeDetailButton.Tag = move.Type;
        PPTextBox.Text = $"{move.PP}";
        MetaDetailButton.Tag = move.Meta;
        AccuracyTextBox.Text = $"{move.Accurary}";
        PowerTextBox.Text = $"{move.Power}";
        GenerationTextBox.Text = move.Generation?.Name ?? string.Empty;
        GenerationDetailButton.Tag = move.Generation;
        TargetTextBox.Text = move.Target?.Name ?? string.Empty;
        TargetDetailButton.Tag = move.Target;
        EffectChanceTextBox.Text = $"{move.EffectChance}";
        PriorityTextBox.Text = $"{move.Priority}";
        DamageClassTextBox.Text = move.DamageClass?.Name ?? string.Empty;
        DamageClassDetailButton.Tag = move.DamageClass;
        ContestTypeTextBox.Text = move.ContestType?.Name ?? string.Empty;
        ContestTypeDetailButton.Tag = move.ContestType;
        if (move.ContestCombos is null) {
            ContestCombosDetailButton.Enabled = false;
        }
        ContestCombosDetailButton.Tag = move.ContestCombos;
        ContestEffectTextBox.Text = move.ContestEffect?.Name ?? string.Empty;
        ContestEffectDetailButton.Tag = move.ContestEffect;
        SuperContestEffectTextBox.Text = move.SuperContestEffect?.Name ?? string.Empty;
        SuperContestEffectDetailButton.Tag = move.SuperContestEffect;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = move.Names;
        LearnedByPokemonDataGridView.AutoGenerateColumns = false;
        LearnedByPokemonDataGridView.DataSource = move.LearnedByPokemon;
        FlavorTextEntriesDataGridView.AutoGenerateColumns = false;
        FlavorTextEntriesDataGridView.DataSource = move.FlavorTextEntries;
        EffectEntriesDataGridView.AutoGenerateColumns = false;
        EffectEntriesDataGridView.DataSource = move.EffectEntries;
        EffectChangesDataGridView.AutoGenerateColumns = false;
        EffectChangesDataGridView.DataSource = move.EffectChanges;
        MachinesDataGridView.AutoGenerateColumns = false;
        MachinesDataGridView.DataSource = move.Machines;
        StatChangeDataGridView.AutoGenerateColumns = false;
        StatChangeDataGridView.DataSource = move.StatChanges;
        PastValuesDataGridView.AutoGenerateColumns = false;
        PastValuesDataGridView.DataSource = move.PastValues;
    }
    #endregion
}
