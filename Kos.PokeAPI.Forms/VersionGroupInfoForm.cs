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
using Kos.PokeAPI.Games.VersionGroups;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// バージョングループ
/// </summary>
public partial class VersionGroupInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public VersionGroupInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region 世代 クリック
    /// <summary>
    /// 世代 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GenerationInfoButton_Click(object sender, EventArgs e)
    {
        if (GenerationButton.Tag is null) {
            return;
        }

        if (GenerationButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using GenerationInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技の習得方法 セルクリック
    /// <summary>
    /// 技の習得方法 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveLearnMethodsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (MoveLearnMethodsDataGridView[e.ColumnIndex, e.RowIndex] is not
            DataGridViewButtonCell) {
            return;
        }

        if (MoveLearnMethodsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using MoveLearnMethodInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 技の習得方法 セルダブルクリック
    /// <summary>
    /// 技の習得方法 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        MoveLearnMethodsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (MoveLearnMethodsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using MoveLearnMethodInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 地域 セルクリック
    /// <summary>
    /// 地域 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RegionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (RegionsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (RegionsDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using RegionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region 地域 セルダブルクリック
    /// <summary>
    /// 地域 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RegionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (RegionsDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using RegionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ポケモン図鑑 セルクリック
    /// <summary>
    /// ポケモン図鑑 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokedexesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (PokedexesDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (PokedexesDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using PokedexInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ポケモン図鑑 セルダブルクリック
    /// <summary>
    /// ポケモン図鑑 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokedexesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (PokedexesDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using PokedexInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョン セルクリック
    /// <summary>
    /// バージョン セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (VersionsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (VersionsDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョン セルダブルクリック
    /// <summary>
    /// バージョン セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (VersionsDataGridView.Rows[e.RowIndex].DataBoundItem is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region プロティ クリック
    /// <summary>
    /// プロティ クリック
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


    // メソッド

    #region データの表示
    /// <summary>
    /// データの表示
    /// </summary>
    /// <param name="url">URL</param>
    void SetData(string url)
    {
        VersionGroup? group = VersionGroup.GetVersionGroup(url);
        if (group is null) {
            return;
        }

        Tag = group;
        FormsHelper.SetData(group.Id, IdCaptionLabel, IdTextBox);
        FormsHelper.SetData(group.Name, NameCaptionLabel, NameTextBox);
        FormsHelper.SetData(group.Order, OrderCaptionLabel, OrderTextBox);
        FormsHelper.SetData(group.Generation, GenerationButton, GenerationTextBox);
        FormsHelper.SetData(group.MoveLearnMethods, MoveLearnMethodsCaptionLabel, MoveLearnMethodsDataGridView);
        FormsHelper.SetData(group.Pokedexes, PokedexesCaptionLabel, PokedexesDataGridView);
        FormsHelper.SetData(group.Regions, RegionsCaptionLabel, RegionsDataGridView);
        FormsHelper.SetData(group.Versions, VersionsCaptionLabel, VersionsDataGridView);
    }
    #endregion
}
