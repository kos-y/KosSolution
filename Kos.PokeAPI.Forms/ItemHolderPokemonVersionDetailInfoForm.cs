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
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// アイテム保持ポケモンバージョン詳細
/// </summary>
public partial class ItemHolderPokemonVersionDetailInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ihpvd">アイテム保持ポケモンバージョン詳細</param>
    public ItemHolderPokemonVersionDetailInfoForm(ItemHolderPokemonVersionDetail ihpvd)
    {
        InitializeComponent();
        SetData(ihpvd);
    }
    #endregion

    #region バージョン 詳細 クリック
    /// <summary>
    /// バージョン 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionDetailButton_Click(object sender, EventArgs e)
    {
        if (VersionDetailButton.Tag is null) {
            return;
        }

        if (VersionDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
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
    /// <param name="ihpvd"></param>
    public void SetData(ItemHolderPokemonVersionDetail ihpvd)
    {
        RarityTextBox.Text = $"{ihpvd.Rarity}";
        VersionTextBox.Text = ihpvd.Version?.Name ?? string.Empty;
        VersionDetailButton.Tag = ihpvd.Version;
    }
    #endregion
}
