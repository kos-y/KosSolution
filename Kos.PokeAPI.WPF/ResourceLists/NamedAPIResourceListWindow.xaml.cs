using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kos.PokeAPI.WPF.ResourceLists;

/// <summary>
/// NamedAPIResourceListWindow.xaml の相互作用ロジック
/// </summary>
public partial class NamedAPIResourceListWindow : Window
{
    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public NamedAPIResourceListWindow()
    {
        InitializeComponent();
    }
    #endregion

    #region 閉じる クリック
    /// <summary>
    /// 閉じる クリック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }
    #endregion
}
