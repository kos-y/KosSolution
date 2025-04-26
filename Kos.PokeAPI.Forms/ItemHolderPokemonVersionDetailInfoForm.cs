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
    }
    #endregion

    #region version Info Click
    /// <summary>
    /// version Info Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionInfoButton_Click(object sender, EventArgs e)
    {
        object? tag = VersionInfoButton.Tag;
        if (tag is null) {
            return;
        }

        if (tag is not NamedAPIResource api) {
            return;
        }

        if (api?.Url is null) {
            return;
        }

        using VersionInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
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

    #region データの設定
    /// <summary>
    /// データの設定
    /// </summary>
    /// <param name="ihpvd"></param>
    public void SetData(ItemHolderPokemonVersionDetail ihpvd)
    {
        RarityLabel.Text = $"{ihpvd.Rarity}";
        VersionLabel.Text = ihpvd.Version?.Name ?? string.Empty;
        VersionInfoButton.Tag = ihpvd.Version;
    }
    #endregion
}
