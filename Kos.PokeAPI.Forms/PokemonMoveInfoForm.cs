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
using Kos.PokeAPI.Pokemon.Pokemon;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ポケモンの技
/// </summary>
public partial class PokemonMoveInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="move"></param>
    public PokemonMoveInfoForm(PokemonMove move)
    {
        InitializeComponent();
        SetData(move);
    }
    #endregion

    #region 技 クリック
    /// <summary>
    /// 技 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveButton_Click(object sender, EventArgs e)
    {
        if (MoveButton.Tag is null) {
            return;
        }

        if (MoveButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using MoveInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョングループごとの詳細 セルクリック
    /// <summary>
    /// バージョングループごとの詳細 セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (VersionGroupDetailsDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (VersionGroupDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonMoveVersion version) {
            return;
        }

        using PokemonMoveVersionInfoForm form = new(version);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region バージョングループごとの詳細 セルダブルクリック
    /// <summary>
    /// バージョングループごとの詳細 セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (VersionGroupDetailsDataGridView.Rows[e.RowIndex].DataBoundItem is not PokemonMoveVersion version) {
            return;
        }

        using PokemonMoveVersionInfoForm form = new(version);
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
    /// <param name="move"></param>
    private void SetData(PokemonMove move)
    {
        Tag = move;
        FormsHelper.SetData(move.Move, MoveButton, MoveTextBox);
        FormsHelper.SetData(move.VersionGroupDetails, VersionGroupDetailsDataGridView);
    }
    #endregion
}
