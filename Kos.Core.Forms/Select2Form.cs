namespace Kos.Core.Forms;

public partial class Select2Form : Form
{
    // �t�B�[���h

    #region �I�����P�e�L�X�g
    /// <summary>
    /// �I�����P�e�L�X�g
    /// </summary>
    private readonly string _select1Text;
    #endregion

    #region �I�����Q�e�L�X�g
    /// <summary>
    /// �I�����Q�e�L�X�g
    /// </summary>
    private readonly string _select2Text;
    #endregion

    #region �I������
    /// <summary>
    /// �I������
    /// </summary>
    public Select2Result Result = Select2Result.None;
    #endregion


    // ���\�b�h

    #region �R���X�g���N�^
    /// <summary>
    /// �R���X�g���N�^
    /// </summary>
    /// <param name="select1Text">�I�����P�e�L�X�g</param>
    /// <param name="select2Text">�I�����Q�e�L�X�g</param>
    public Select2Form(string select1Text, string select2Text)
    {
        InitializeComponent();
        _select1Text = select1Text;
        _select2Text = select2Text;
    }
    #endregion

    #region Load
    /// <summary>
    /// Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Select2Form_Load(object sender, EventArgs e)
    {
        Select1Button.Text = _select1Text;
        Select2Button.Text = _select2Text;
    }
    #endregion

    #region �I�����P �N���b�N
    /// <summary>
    /// �I�����P �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Select1Button_Click(object sender, EventArgs e)
    {
        Result = Select2Result.Select1;
        DialogResult = DialogResult.OK;
        Close();
    }
    #endregion

    #region �I�����Q �N���b�N
    /// <summary>
    /// �I�����Q �N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Select2Button_Click(object sender, EventArgs e)
    {
        Result = Select2Result.Select2;
        DialogResult= DialogResult.OK;
        Close();
    }
    #endregion
}
