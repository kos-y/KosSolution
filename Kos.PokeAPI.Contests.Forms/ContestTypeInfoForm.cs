using Kos.PokeAPI.Contests.ContestTypes;
using Kos.PokeAPI.Utility.CommonModels;

namespace Kos.PokeAPI.Contests.Forms;

/// <summary>
/// Contest Type
/// </summary>
public partial class ContestTypeInfoForm : Form
{
    // �t�B�[���h

    #region URL
    /// <summary>
    /// URL
    /// </summary>
    private readonly string _url;
    #endregion

    // ���\�b�h

    #region �R���X�g���N�^
    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    /// <param name="url">URL</param>
    public ContestTypeInfoForm(string url)
    {
        InitializeComponent();
        _url = url;
    }
    #endregion

    #region Load
    /// <summary>
    /// Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContestTypeInfoForm_Load(object sender, EventArgs e)
    {
        SetData(_url);
    }
    #endregion

    #region Berry Flavor Info Click
    /// <summary>
    /// Berry Flavor Info Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BerryFlavorInfoButton_Click(object sender, EventArgs e)
    {
        object? tag = BerryFlavorInfoButton.Tag;

        if (tag is null) {
            return;
        }

        if (tag is not NamedAPIResource api) {
            return;
        }

        
    }
    #endregion

    #region �f�[�^�̕\��
    /// <summary>
    /// �f�[�^�̕\��
    /// </summary>
    /// <param name="url">URL</param>
    private void SetData(string url)
    {
        ContestType? ct = ContestType.GetContestType(url);
        if (ct is null) {
            return;
        }

        Tag = ct;
        IdLabel.Text = $"{ct.Id}";
        NameLabel.Text = ct.Name;
        BerryFlavorLabel.Text = ct.BerryFlavor.Name ?? string.Empty;
        BerryFlavorInfoButton.Tag = ct.BerryFlavor;
        NamesDataGridView.DataSource = ct.Names;
    }
    #endregion
}
