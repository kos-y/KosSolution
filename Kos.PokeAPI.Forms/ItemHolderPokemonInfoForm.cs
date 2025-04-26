using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Items.Item;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// アイテム保持ポケモン
/// </summary>
public partial class ItemHolderPokemonInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ihp">アイテム保持ポケモン</param>
    public ItemHolderPokemonInfoForm(ItemHolderPokemon ihp)
    {
        InitializeComponent();
        SetData(ihp);
    }
    #endregion

    #region version_details DataGridView CellClick
    /// <summary>
    /// version_details DataGridView CellClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (VersionDetailsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (VersionDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region version_details DataGrdiView CellDoubleClick
    /// <summary>
    /// version_details DataGrdiView CellDoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void
        VersionDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (VersionDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not
            NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region Close Button
    /// <summary>
    /// Close Button
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
    /// <param name="ihp">アイテム保持ポケモン</param>
    private void SetData(ItemHolderPokemon ihp)
    {
        PokemonLabel.Text = ihp.Pokemon?.Name ?? string.Empty;
        PokemonInfoButton.Tag = ihp.Pokemon;
        VersionDetailsDataGridView.AutoGenerateColumns = false;
        VersionDetailsDataGridView.DataSource = ihp;
    }
    #endregion
}
