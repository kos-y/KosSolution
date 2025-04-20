namespace Kos.Core.Forms;

public partial class Select2Form : Form
{
    // フィールド

    #region 選択肢１テキスト
    /// <summary>
    /// 選択肢１テキスト
    /// </summary>
    private readonly string _select1Text;
    #endregion

    #region 選択肢２テキスト
    /// <summary>
    /// 選択肢２テキスト
    /// </summary>
    private readonly string _select2Text;
    #endregion

    #region 選択結果
    /// <summary>
    /// 選択結果
    /// </summary>
    public Select2Result Result = Select2Result.None;
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="select1Text">選択肢１テキスト</param>
    /// <param name="select2Text">選択肢２テキスト</param>
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

    #region 選択肢１ クリック
    /// <summary>
    /// 選択肢１ クリック
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

    #region 選択肢２ クリック
    /// <summary>
    /// 選択肢２ クリック
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
