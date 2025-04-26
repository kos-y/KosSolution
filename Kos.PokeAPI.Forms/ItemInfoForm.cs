using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.Core;
using Kos.PokeAPI.Items.Item;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;
public partial class ItemInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="url">URL</param>
    public ItemInfoForm(string url)
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

    #region ゲーム内インデックス セルクリック
    /// <summary>
    /// ゲーム内インデックス セルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GameIndiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) {
            return;
        }

        if (GameIndiceDataGridView[e.ColumnIndex, e.RowIndex] is not DataGridViewButtonCell) {
            return;
        }

        if (GameIndiceDataGridView.Rows[e.RowIndex].DataBoundItem is not GenerationGameIndex ggi) {
            return;
        }

        GenerationGameIndexInfoForm form = new(ggi);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ゲーム内インデックス セルダブルクリック
    /// <summary>
    /// ゲーム内インデックス セルダブルクリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GameIndiceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) {
            return;
        }

        if (GameIndiceDataGridView.Rows[e.RowIndex].DataBoundItem is not GenerationGameIndex ggi) {
            return;
        }

        GenerationGameIndexInfoForm form = new(ggi);
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
    private void
        EffectEntriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            VersionGroupFlavorText vgft) {
            return;
        }

        using VersionGroupFlavorTextInfoForm form = new(vgft);
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
            VersionGroupFlavorText vgft) {
            return;
        }

        using VersionGroupFlavorTextInfoForm form = new(vgft);
        _ = form.ShowDialog(this);
    }
    #endregion

    #region ベビーポケモンの進化トリガー クリック
    /// <summary>
    /// ベビーポケモンの進化トリガー クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BabyTriggerForInfoButton_Click(object sender, EventArgs e)
    {
        if (BabyTriggerForInfoButton.Tag is null) {
            return;
        }

        if (BabyTriggerForInfoButton.Tag is not APIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using EvolutionChainInfoForm form = new(api.Url);
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

    #region 画面にデータの設定
    /// <summary>
    /// 画面にデータの設定
    /// </summary>
    /// <param name="url"></param>
    private void SetData(string url)
    {
        Item? item = Item.GetItem(url);
        if (item is null) {
            return;
        }

        IdLabel.Text = $"{item.Id}";
        NameLabel.Text = item.Name;
        CostLabel.Text = $"{item.Cost}";
        CategoryLabel.Text = item.Category?.Name ?? string.Empty;
        CategoryInfoButton.Tag = item.Category;
        FlingEffectLabel.Text = item.FlingEffect?.Name ?? string.Empty;
        FlingPowerLabel.Text = $"{item.FlingPower}";
        if (item.BabyTriggerFor is not null) {
            BabyTriggerForInfoButton.Tag = item.BabyTriggerFor;
        } else {
            BabyTriggerForInfoButton.Enabled = false;
        }
        AttributesDataGridView.AutoGenerateColumns = false;
        AttributesDataGridView.DataSource = item.Attributes;
        FlavorTextEntriesDataGridView.AutoGenerateColumns = false;
        FlavorTextEntriesDataGridView.DataSource = item.FlavorTextEntries;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = item.Names;
        MachinesDataGridView.AutoGenerateColumns = false;
        MachinesDataGridView.DataSource = item.Machines;
        EffectEntriesDataGridView.AutoGenerateColumns = false;
        EffectEntriesDataGridView.DataSource = item.EffectEntries;
        GameIndiceDataGridView.AutoGenerateColumns = false;
        GameIndiceDataGridView.DataSource = item.GameIndice;
        HeldByPokemonDataGridView.AutoGenerateColumns = false;
        HeldByPokemonDataGridView.DataSource = item.HeldByPokemon;

        if (item.Sprites?.Default is not null) {
            using Stream s
                = Singleton<HttpClient>.Instance
                                       .GetAsync(item.Sprites?.Default)
                                       .Result
                                       .Content
                                       .ReadAsStreamAsync()
                                       .Result;

            SpritesPictureBox.Image = Image.FromStream(s);
        }
    }
    #endregion
}
