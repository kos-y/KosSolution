using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Items;
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

    #region バージョンごとの詳細 セルクリック
    /// <summary>
    /// バージョンごとの詳細 セルクリック
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
            ItemHolderPokemonVersionDetail ihpvd) {
            return;
        }

        using ItemHolderPokemonVersionDetailInfoForm form = new(ihpvd);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョンごとの詳細 セルダブルクリック
    /// <summary>
    /// バージョンごとの詳細 セルダブルクリック
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
            ItemHolderPokemonVersionDetail ihpvd) {
            return;
        }

        using ItemHolderPokemonVersionDetailInfoForm form = new(ihpvd);
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
        PokemonDetailButton.Tag = ihp.Pokemon;
        VersionDetailsDataGridView.AutoGenerateColumns = false;
        VersionDetailsDataGridView.DataSource = ihp.VersionDetails;
    }
    #endregion
}
