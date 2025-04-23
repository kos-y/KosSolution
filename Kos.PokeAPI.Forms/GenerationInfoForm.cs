using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kos.PokeAPI.Evolution.EvolutionTriggers;
using Kos.PokeAPI.Games.Generations;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// 世代
/// </summary>
public partial class GenerationInfoForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public GenerationInfoForm(string url)
    {
        InitializeComponent();
        SetData(url);
    }
    #endregion

    #region データの表示
    /// <summary>
    /// データの表示
    /// </summary>
    /// <param name="url">URL</param>
    public void SetData(string url)
    {
        Generation? g = Generation.GetGeneration(url);
        if (g is null) {
            return;
        }

        IdLabel.Text = $"{g.Id}";
        NameLabel.Text = g.Name ?? string.Empty;
        NamesDataGridView.AutoGenerateColumns = false;
        NamesDataGridView.DataSource = g.Names;
        AbilitiesDataGridView.AutoGenerateColumns = false;
        AbilitiesDataGridView.DataSource = g.PokemonSpecies;
    }
    #endregion
}
