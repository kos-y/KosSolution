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
using Kos.PokeAPI.Locations.LocationAreas;
using Kos.PokeAPI.Utility.CommonModels;
using Kos.PokeAPI.Utility.Languages;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 場所エリア
/// </summary>
public partial class LocationAreaInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url"></param>
    public LocationAreaInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region 場所 クリック
    /// <summary>
    /// 場所 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LocationButton_Click(object sender, EventArgs e)
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

    #region 言語ごとの名前 セルクリック
    /// <summary>
    /// 言語ごとの名前 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NamesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex < 0 || e.RowIndex < 0) {
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

    #region 遭遇率 セルクリック
    /// <summary>
    /// 遭遇率 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EncounterMethodRateDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (EncounterMethodRateDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (EncounterMethodRateDataGridView.Rows[e.RowIndex].DataBoundItem is not
            EncounterMethodRate emr) {
            return;
        }

        EncounterMethodRateInfoForm form = new(emr);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇率 セルダブルクリック
    /// <summary>
    /// 遭遇率 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        EncounterMethodRateDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (EncounterMethodRateDataGridView.Rows[e.RowIndex].DataBoundItem is not
            EncounterMethodRate emr) {
            return;
        }

        EncounterMethodRateInfoForm form = new(emr);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇ポケモン セルクリック
    /// <summary>
    /// 遭遇ポケモン セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        PokemonEncountersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (PokemonEncountersDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (PokemonEncountersDataGridView.Rows[e.RowIndex].DataBoundItem is not
            PokemonEncounter pe) {
            return;
        }

        using PokemonEncounterInfoForm form = new(pe);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 遭遇ポケモン セルダブルクリック
    /// <summary>
    /// 遭遇ポケモン セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        PokemonEncountersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (PokemonEncountersDataGridView.Rows[e.RowIndex].DataBoundItem is not
            PokemonEncounter pe) {
            return;
        }

        using PokemonEncounterInfoForm form = new(pe);
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
    /// <param name="url">URL</param>
    private void SetData(string url)
    {
        LocationArea? area = LocationArea.GetResource(url);
        if (area is null) {
            return;
        }

        Tag = area;
        FormsHelper.SetData(area.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(area.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(area.GameIndex, GameIndexCaptionLabel, GameIndexTextBox);
        FormsHelper.SetData(area.Location, LocationButton, LocationTextBox);
        FormsHelper.SetData(area.Names, NamesCaptionLabel, NamesDataGridView);
        FormsHelper.SetData(
            area.EncounterMethodRates,
            EncounterMethodRateCaptionLabel,
            EncounterMethodRateDataGridView);
        FormsHelper.SetData(
            area.PokemonEncounters,
            PokemonEncountersCaptionLabel,
            PokemonEncountersDataGridView);
    }
    #endregion
}
