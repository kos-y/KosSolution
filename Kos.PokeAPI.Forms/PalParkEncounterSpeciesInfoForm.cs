using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    #region ポケモン種族 詳細 クリック
    /// <summary>
    /// ポケモン種族 詳細 クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokemonSpeciesDetailButton_Click(object sender, EventArgs e)
    {
        if (PokemonSpeciesDetailButton.Tag is null) {
            return;
        }

        if (PokemonSpeciesDetailButton.Tag is not NamedAPIResource api) {
            return;
        }

        if (api.Url is null) {
            return;
        }


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
    /// <param name="ppes"></param>
    private void SetData(PalParkEncounterSpecies ppes)
    {
        PokemonSpeciesTextBox.Text = ppes.PokemonSpecies?.Name ?? string.Empty;
        PokemonSpeciesDetailButton.Tag = ppes.PokemonSpecies;
        BaseScoreTextBox.Text = $"{ppes.BaseScore}";
        RateTextBox.Text = $"{ppes.Rate}";
    }
    #endregion
}
