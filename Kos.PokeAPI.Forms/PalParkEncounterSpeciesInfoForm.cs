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
using Kos.PokeAPI.Locations.PalParkAreas;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// パルパークエリア内で遭遇するポケモン種族
/// </summary>
public partial class PalParkEncounterSpeciesInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ppes"></param>
    public PalParkEncounterSpeciesInfoForm(PalParkEncounterSpecies ppes)
    {
        InitializeComponent();
        SetData(ppes);
    }
    #endregion

    #region ポケモン種族 クリック
    /// <summary>
    /// ポケモン種族 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokemonSpeciesButton_Click(object sender, EventArgs e)
    {
        if (PokemonSpeciesButton.Tag is null) {
            return;
        }

        if (PokemonSpeciesButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }


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
    /// <param name="species"></param>
    private void SetData(PalParkEncounterSpecies species)
    {
        Tag = species;
        FormsHelper.SetData(species.PokemonSpecies, PokemonSpeciesButton, PokemonSpeciesTextBox);
        FormsHelper.SetData(species.BaseScore, BaseScoreCaptionLabel, BaseScoreTextBox);
        FormsHelper.SetData(species.Rate, RateCaptionLabel, RateTextBox);
    }
    #endregion
}
