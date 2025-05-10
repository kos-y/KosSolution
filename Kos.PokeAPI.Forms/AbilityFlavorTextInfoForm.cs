using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Pokemon.Abilities;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 特性のフレーバーテキスト
/// </summary>
public partial class AbilityFlavorTextInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public AbilityFlavorTextInfoForm(AbilityFlavorText aft)
    {
        InitializeComponent();
        SetData(aft);
    }
    #endregion

    #region バージョングループ 詳細 クリック
    /// <summary>
    /// バージョングループ 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VersionGroupDetailButton_Click(object sender, EventArgs e)
    {
        if (VersionGroupDetailButton.Tag is null) {
            return;
        }

        if (VersionGroupDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }

        using VersionGroupInfoForm form = new(api.Url);
        _ = form.ShowDialog(this);
    }
    #endregion

    private void LanguageDetailButton_Click(object sender, EventArgs e)
    {

    }

    #region データの設定
    /// <summary>
    /// データの設定
    /// </summary>
    /// <param name="aft"></param>
    public void SetData(AbilityFlavorText aft)
    {
        VersionGroupTextBox.Text = aft.VersionGroup?.Name ?? string.Empty;
        VersionGroupDetailButton.Tag = aft.VersionGroup;
        LanguageTextBox.Text = aft.Language?.Name ?? string.Empty;
        LanguageDetailButton.Tag = aft.Language;
        FlavorTextTextBox.Text = aft.FlavorText;
    }
    #endregion
}
