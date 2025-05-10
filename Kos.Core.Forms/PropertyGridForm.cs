using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kos.Core.Forms;

/// <summary>
/// プロパティ情報
/// </summary>
public partial class PropertyGridForm : Form
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="obj">オブジェクト</param>
    public PropertyGridForm(object obj)
    {
        InitializeComponent();
        PropertyGrid.SelectedObject = obj;
        PropertyGrid.CommandsVisibleIfAvailable = false;
        PropertyGrid.Refresh();
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
}
