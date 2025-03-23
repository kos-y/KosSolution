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
using KCSEventLog;
using KCSEventLogWPF;

namespace KCSEventLogViewerWPF;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// ViewModel
    /// </summary>
    private readonly KEventLogMainViewModel _viewModel = new();

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();

        DataContext = _viewModel;
    }

    /// <summary>
    /// イベントログリストの選択変更
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
#pragma warning disable IDE1006
    private void lbEventLog_SelectionChanged(object sender, SelectionChangedEventArgs e)
#pragma warning restore IDE1006
    {
        if (lbEventLog.SelectedItem is not null) {
            _viewModel.SelectionChangeEventLog((KEventLog)lbEventLog.SelectedItem);
        }
    }
}