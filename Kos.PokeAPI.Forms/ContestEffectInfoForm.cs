using Kos.Core.Forms;
using Kos.PokeAPI.Contests.ContestEffects;
using Kos.PokeAPI.Contests.ContestTypes;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// コンテスト効果
/// </summary>
public partial class ContestEffectInfoForm : Form
{
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
    public ContestEffectInfoForm(string url)
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
    private void ContestEffectInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
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

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not Effect effect) {
            return;
        }

        if (effect.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(effect.Language.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region  効果 セルダブルクリック
    /// <summary>
    /// 効果 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EffectEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EffectEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not Effect effect) {
            return;
        }

        if (effect.Language?.Url is null) {
            return;
        }

        using LanguageInfoForm form = new(effect.Language.Url);
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

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not FlavorText ft) {
            return;
        }

        using FlavorTextInfoForm form = new(ft);
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

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not FlavorText ft) {
            return;
        }

        using FlavorTextInfoForm form = new(ft);
        _ = form.ShowDialog(this);
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
    /// <param name="url">URL</param>
    private void SetData(string url)
    {
        ContestEffect? ce = ContestEffect.GetContestEffect(url);
        if (ce is null) {
            return;
        }

        Tag = ce;
        IdLabel.Text = $"{ce.Id}";
        AppealLabel.Text = $"{ce.Appeal}";
        JamLabel.Text = $"{ce.Jam}";
        EffectEntriesDataGridView.DataSource = ce.EffectEntries;
        FlavorTextEntriesDataGridView.DataSource = ce.FlavorTextEntries;
    }
    #endregion
}
