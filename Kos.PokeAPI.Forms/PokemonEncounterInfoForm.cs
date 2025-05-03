using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Locations.LocationAreas;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモン遭遇情報
/// </summary>
public partial class PokemonEncounterInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="pe"></param>
    public PokemonEncounterInfoForm(PokemonEncounter pe)
    {
        InitializeComponent();
        SetData(pe);
    }
    #endregion

    #region ポケモン 詳細 クリック
    /// <summary>
    /// ポケモン 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokemonDetailButton_Click(object sender, EventArgs e)
    {
        if (PokemonDetailButton.Tag is null) {
            return;
        }

        if (PokemonDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }
    }
    #endregion

    #region バージョンごとの遭遇情報 セルクリック
    /// <summary>
    /// バージョンごとの遭遇情報 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EncounterDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EncounterDetailsDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (EncounterDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            VersionEncounterDetail evd) {
            return;
        }

        using VersionEncounterDetailInfoForm form = new(evd);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョンごとの遭遇情報 セルダブルクリック
    /// <summary>
    /// バージョンごとの遭遇情報 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EncounterDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EncounterDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            VersionEncounterDetail evd) {
            return;
        }

        using VersionEncounterDetailInfoForm form = new(evd);
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
    /// <param name="pe"></param>
    private void SetData(PokemonEncounter pe)
    {
        PokemonTextBox.Text = pe.Pokemon?.Name ?? string.Empty;
        PokemonDetailButton.Tag = pe.Pokemon;
        EncounterDetailsDataGridView.AutoGenerateColumns = false;
        EncounterDetailsDataGridView.DataSource = pe.VersionDetails;
    }
    #endregion
}
