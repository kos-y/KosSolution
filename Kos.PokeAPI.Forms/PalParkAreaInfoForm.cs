using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Locations.PalParkAreas;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// パルパークエリア
/// </summary>
public partial class PalParkAreaInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PalParkAreaInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
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

        using NameInfoForm form = new NameInfoForm(name);
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

        using NameInfoForm form = new NameInfoForm(name);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇ポケモン セルクリック
    /// <summary>
    /// 遭遇ポケモン セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokemonEncountersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (PokemonEncountersDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (PokemonEncountersDataGridView.Rows[e.RowIndex].DataBoundItem is not
            PalParkEncounterSpecies ppes) {
            return;
        }

        using PalParkEncounterSpeciesInfoForm form = new(ppes);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇ポケモン セルダブルクリック
    /// <summary>
    /// 遭遇ポケモン セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokemonEncountersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (PokemonEncountersDataGridView.Rows[e.RowIndex].DataBoundItem is not
            PalParkEncounterSpecies ppes) {
            return;
        }

        using PalParkEncounterSpeciesInfoForm form = new(ppes);
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
        PalParkArea? ppa = PalParkArea.GetResource(url);
        if (ppa is null) {
            return;
        }

        IdTextBox.Text = $"{ppa.Id}";
        NameTextBox.Text = ppa.Name;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = ppa.Names;
        PokemonEncountersDataGridView.AutoGenerateColumns = false;
        PokemonEncountersDataGridView.DataSource = ppa.PokemonEncounters;
    }
    #endregion
}
