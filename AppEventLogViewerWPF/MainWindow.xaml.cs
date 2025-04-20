using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kos.EventLog.WPF;

namespace AppEventLogViewerWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // フィールド

    #region イベントログ ViewModel
    /// <summary>
    /// イベントログ ViewModel
    /// </summary>
    private EventLogViewModel _eventLogViewModel = new();
    #endregion


    // メソッド

    #region コンストラクタ
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();

        DataContext = _eventLogViewModel;
    }
    #endregion
}