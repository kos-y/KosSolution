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
using Kos.PokeAPI.Contests.ContestEffects;
using Kos.PokeAPI.Contests.SuportContestEffects;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// スーパーコンテストの効果
/// </summary>
public partial class SuperContestEffectInfoForm : Form
{
    // フィールド

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public SuperContestEffectInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region Load
    /// <summary>
    /// Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SuperContestEffectInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region flavor_text_entries DataGridView CellClick
    /// <summary>
    /// flavor_text_entries DataGridView CellClick
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

        switch (FlavorTextEntriesDataGridView.Columns[e.ColumnIndex].Name) {
        case nameof(FlavorTextLanguageInfoButtonColumn): {
                if (ft.Language?.Url is null) {
                    return;
                }

                using LanguageInfoForm form = new(ft.Language.Url);
                _ = form.ShowDialog(this);
            }
            break;

        case nameof(FlavorTextVersionInfoButtonColumn): {
                if (ft.Version?.Url is null) {
                    return;
                }
            }
            break;

        default:
            break;
        }
    }
    #endregion

    #region flavor_text_entries DataGridView CellDoubleClick
    /// <summary>
    /// flavor_text_entries DataGridView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FlavorTextEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (FlavorTextEntriesDataGridView.Rows[e.RowIndex].DataBoundItem is not FlavorText ft) {
            return;
        }

        Select2Form selForm = new("Language", "Version");
        if (selForm.ShowDialog(this) == DialogResult.OK) {
            switch (selForm.Result) {
            case Select2Result.Select1: {
                    if (ft.Language?.Url is null) {
                        return;
                    }

                    using LanguageInfoForm form = new(ft.Language.Url);
                    _ = form.ShowDialog(this);
                }
                break;

            case Select2Result.Select2: {
                    if (ft.Version?.Url is null) {
                        return;
                    }
                }
                break;

            default:
                break;
            }
        }
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
        SuperContestEffect? sce = SuperContestEffect.GetSuperContestEffect(url);
        if (sce is null) {
            return;
        }

        Tag = sce;
        IdLabel.Text = $"{sce.Id}";
        AppealLabel.Text = $"{sce.Appeal}";
        FlavorTextEntriesDataGridView.DataSource = sce.FlavorTextEntries;
        MovesDataGridView.AutoGenerateColumns = false;
        MovesDataGridView.DataSource = sce.Moves;
    }
    #endregion
}
